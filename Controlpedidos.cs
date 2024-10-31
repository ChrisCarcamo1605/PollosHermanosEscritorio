using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PollosHermanosRP
{
    public partial class Controlpedidos : Form
    {
        public bool isefectivo => chkefectivo.Checked;
        public bool istarjeta => chktarjeta.Checked;

        private string conexion = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";

        public Controlpedidos()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Crear la consulta SQL con INNER JOIN
            string query = @"
            SELECT Pedido.ID AS PedidoID, Mesa.NoMesa, Pedido.Cliente, Pedido.detallesPedido, Pedido.fecha, Funcionario.Nombre AS NombreMesero, Pedido.Total_a_pagar, Pedido.metodo_de_pago, Pedido.Activo
            FROM Pedido
            INNER JOIN Mesa ON Pedido.NumeroMesa = Mesa.ID
            INNER JOIN Funcionario ON Pedido.Mesero = Funcionario.ID
            WHERE Pedido.Activo = '1'";

            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                try
                {
                    // Llenar el DataTable con los datos
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable al DataGridView
                    dtgpedidos.DataSource = dataTable;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chktarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (chktarjeta.Checked)
            {
                if (chkefectivo.Checked)
                {
                    chkefectivo.Checked = false;
                }
            }
        }

        private void chkefectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkefectivo.Checked)
            {
                if (chktarjeta.Checked)
                {
                    chktarjeta.Checked = false;
                }
            }
        }

        public void imprimirDatos()
        {
            try
            {
                string consulta = @"
                SELECT Pedido.ID AS PedidoID, Mesa.NoMesa, Pedido.Cliente, Pedido.detallesPedido, Pedido.fecha, Funcionario.Nombre AS NombreMesero, Pedido.Total_a_pagar, Pedido.metodo_de_pago, Pedido.Activo
                FROM Pedido
                INNER JOIN Mesa ON Pedido.NumeroMesa = Mesa.ID
                INNER JOIN Funcionario ON Pedido.Mesero = Funcionario.ID
                WHERE Pedido.Activo = '1'";

                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    MySqlDataAdapter comando = new MySqlDataAdapter(consulta, con);
                    DataTable dt1 = new DataTable();
                    comando.Fill(dt1);
                    dtgpedidos.DataSource = dt1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda y eliminar espacios en blanco al inicio y al final
            string textoBuscar = txtbuscar.Text.Trim();

            // Validar el texto de búsqueda
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el texto de búsqueda está vacío, mostrar todos los datos
                imprimirDatos(); // Método para cargar todos los datos con Activo = '1'
            }
            else
            {
                // Realizar la búsqueda en la base de datos
                buscarEnBaseDeDatos(textoBuscar);
            }
        }

        private void buscarEnBaseDeDatos(string textoBuscar)
        {
            try
            {
                string consulta = @"
                SELECT Pedido.ID AS PedidoID, Mesa.NoMesa, Pedido.Cliente, Pedido.detallesPedido, Pedido.fecha, Funcionario.Nombre AS NombreMesero, Pedido.Total_a_pagar, Pedido.metodo_de_pago, Pedido.Activo
                FROM Pedido
                INNER JOIN Mesa ON Pedido.NumeroMesa = Mesa.ID
                INNER JOIN Funcionario ON Pedido.Mesero = Funcionario.ID
                WHERE Pedido.Activo = '1' 
                AND (Pedido.ID LIKE @TextoBuscar OR Mesa.NoMesa LIKE @TextoBuscar OR Pedido.Cliente LIKE @TextoBuscar)";

                using (MySqlConnection con = new MySqlConnection(conexion))
                using (MySqlCommand comando = new MySqlCommand(consulta, con))
                {
                    comando.Parameters.AddWithValue("@TextoBuscar", "%" + textoBuscar + "%");

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable resultados = new DataTable();
                    adaptador.Fill(resultados);

                    // Asignar los resultados al DataGridView
                    dtgpedidos.DataSource = resultados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dtgpedidos.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dtgpedidos.SelectedRows[0];

                // Obtener el ID del pedido desde la fila seleccionada
                int idPedido = Convert.ToInt32(filaSeleccionada.Cells["PedidoID"].Value);

                // Determinar el método de pago actual
                string metodoPago = filaSeleccionada.Cells["metodo_de_pago"].Value.ToString();

                // Determinar si se marca 'Efectivo' o 'Tarjeta'
                bool esEfectivo = isefectivo;
                bool esTarjeta = istarjeta;

                // Validar que solo una opción está seleccionada
                if (!esEfectivo && !esTarjeta)
                {
                    MessageBox.Show("Debe seleccionar un método de pago.");
                    return;
                }

                // Definir el nuevo estado de 'Activo'
                string nuevoEstadoActivo = "0"; // Para cancelar el pedido

                // Actualizar el estado en la base de datos
                try
                {
                    string consulta = "UPDATE Pedido SET Activo = @NuevoEstadoActivo WHERE ID = @IdPedido";
                    using (MySqlConnection con = new MySqlConnection(conexion))
                    using (MySqlCommand comando = new MySqlCommand(consulta, con))
                    {
                        comando.Parameters.AddWithValue("@NuevoEstadoActivo", nuevoEstadoActivo);
                        comando.Parameters.AddWithValue("@IdPedido", idPedido);

                        // Abrir la conexión
                        con.Open();

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        // Verificar si se actualizó algún registro
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El pedido ha sido cancelado.");
                            // Recargar los datos para reflejar los cambios
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el pedido para cancelar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar el pedido: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido para cancelar.");
            }
        }
    }
}
