/*using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollosHermanosRP
{

    public partial class Cuentallevar : Form
    {
        private Pagotarjeta pagotarjeta;
        static string conexion = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";

        MySqlConnection con = new MySqlConnection(conexion);
        public Cuentallevar()
        {
            InitializeComponent();

        }
        private void ActualizarTotal()
        {
            try
            {
                // Inicializa la suma total
                decimal sumaTotal = 0m;

                // Recorre todas las filas en el DataGridView
                foreach (DataGridViewRow fila in dtgfactura.Rows)
                {
                    // Verifica si la fila no es una nueva fila en edición
                    if (!fila.IsNewRow)
                    {
                        // Intenta obtener el valor de la columna Precio (ajusta el índice según tu configuración)
                        if (fila.Cells["Precio"].Value != null)
                        {
                            // Convierte el valor a decimal y suma al total
                            decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                            sumaTotal += precio;
                        }
                    }
                }

                // Actualiza el texto del Label con el total calculado
                lbltotal.Text = $"Total: {sumaTotal}";
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al calcular el total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
       public void imprimirDatos()
        {
            try
            {
                string consulta1 = $"select * from Platillos";
                string consulta2 = $"select * from Bebidas";
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta1, con);
                MySqlDataAdapter comando2 = new MySqlDataAdapter(consulta2, con);
                DataTable dt1 = new DataTable();
                comando.Fill(dt1);
                DataTable dt2 = new DataTable();
                comando2.Fill(dt2);
                dt1.Merge(dt2);
                dtgelementos.DataSource = dt1;
                ActualizarTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            btnbuscar_Click(sender, e); // Llama al método de búsqueda cuando cambia el texto
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Obtener el texto de búsqueda y eliminar espacios en blanco al inicio y al final
            string textoBuscar = txtbuscar.Text.Trim();

            // Validar el texto de búsqueda
            if (string.IsNullOrEmpty(textoBuscar))
            {
                // Si el texto de búsqueda está vacío, mostrar todos los datos
                imprimirDatos(); // Método para cargar todos los datos
            }
            else
            {
                // Realizar la búsqueda en la base de datos
                buscarEnBaseDeDatos(textoBuscar);
            }
        }
        private void buscarEnBaseDeDatos(string textoBuscar)
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                try
                {
                    con.Open();


                    string consulta = @"
                (SELECT 'Platillo' AS Tipo, ID, Nombre, Precio, caracteristica, Descripcion 
                 FROM Platillos 
                 WHERE CONCAT_WS(' ', Nombre, Precio, Tipo, caracteristica, Descripcion) LIKE @TextoBuscar)
                UNION ALL
                (SELECT 'Bebida' AS Tipo, ID, Nombre, Precio,  caracteristica, Descripcion 
                 FROM Bebidas 
                 WHERE CONCAT_WS(' ', Nombre, Precio, Tipo, caracteristica, Descripcion) LIKE @TextoBuscar)";

                    using (MySqlCommand comando = new MySqlCommand(consulta, con))
                    {
                        comando.Parameters.AddWithValue("@TextoBuscar", "%" + textoBuscar + "%");

                        // Depuración: Verificar la consulta SQL
                        Console.WriteLine("Consulta SQL: " + consulta);
                        Console.WriteLine("Texto de búsqueda: " + textoBuscar);
                        //messi
                        MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                        DataTable resultados = new DataTable();
                        adaptador.Fill(resultados);

                        // Depuración: Verificar el número de filas obtenidas
                        Console.WriteLine("Número de filas obtenidas: " + resultados.Rows.Count);

                        // Asignar los resultados al DataGridView
                        dtgelementos.DataSource = resultados;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada en dtgelementos
            if (dtgelementos.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dtgelementos.SelectedRows[0];

                // Obtén los datos de la fila seleccionada
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                decimal precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);

                // Verifica si ya existe una fila con el mismo nombre en dtgFactura

                // Agrega la nueva fila a dtgFactura
                dtgfactura.Rows.Add(nombre, precio);
                ActualizarTotal();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para agregar.");
            }

        }

        private void Cuentallevar_Load(object sender, EventArgs e)
        {
            //PRUEBAAAA
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgfactura.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dtgfactura.SelectedRows[0];
                    if (!selectedRow.IsNewRow)
                    {
                        DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar esta fila?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            dtgfactura.Rows.Remove(selectedRow);
                            // Llama al método para actualizar el total
                            ActualizarTotal();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar una fila nueva en edición.", "Fila Nueva en Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "No hay selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se haya seleccionado un método de pago
                if (cmbmetododepago.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtén el total del pedido
                string totalPedidotexto = lbltotal.Text.Replace("Total: ", "").Replace("₡", "").Trim();
                decimal totalPedido = decimal.Parse(totalPedidotexto);

                // Verifica el método de pago seleccionado
                string metodoPago = cmbmetododepago.SelectedItem.ToString();
                string nombreCliente = "Cliente para Llevar"; // Nombre por defecto para efectivo
                string duiCliente = null;

                if (metodoPago == "Tarjeta")
                {
                    // Muestra el formulario de PagarTarjeta para recoger el nombre y el DUI
                    //using (Pagotarjeta formularioPagarTarjeta = new Pagotarjeta(decimal total))
                    {
                      /*  DialogResult resultado = formularioPagarTarjeta.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            nombreCliente = formularioPagarTarjeta.txtnombre.Text.Trim();
                            duiCliente = formularioPagarTarjeta.txtdui.Text.Trim();

                            // Validación del DUI
                            if (string.IsNullOrEmpty(nombreCliente) || string.IsNullOrEmpty(duiCliente))
                            {
                                MessageBox.Show("Por favor, ingrese todos los datos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (duiCliente.Length != 10)
                            {
                                MessageBox.Show("El DUI debe tener exactamente 10 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                // Construye la cadena con los nombres de los elementos en el DataGridView
                StringBuilder pedidoBuilder = new StringBuilder();
                foreach (DataGridViewRow row in dtgfactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string nombreElemento = row.Cells["Nombre"].Value.ToString();
                        pedidoBuilder.AppendLine(nombreElemento);
                    }
                }
                string pedidoDetalles = pedidoBuilder.ToString().Trim();

                // Insertar la factura en la base de datos
                using (MySqlConnection con = new MySqlConnection(conexion))
                {
                    con.Open();

                    // Crear un nuevo pedido
                    string insertPedido = @"
INSERT INTO Pedido (NumeroMesa, Cliente, Pedido, Mesero, Total_a_pagar, Metodo_de_pago, DUI)
VALUES (NULL, @Cliente, @PedidoDetalles, NULL, @Total, @MetodoPago, @DUI);
SELECT LAST_INSERT_ID();"; // Obtener el ID del pedido recién insertado

                    MySqlCommand cmd = new MySqlCommand(insertPedido, con);
                    cmd.Parameters.AddWithValue("@Cliente", nombreCliente);
                    cmd.Parameters.AddWithValue("@PedidoDetalles", pedidoDetalles);
                    cmd.Parameters.AddWithValue("@Total", totalPedido);
                    cmd.Parameters.AddWithValue("@MetodoPago", metodoPago);
                    cmd.Parameters.AddWithValue("@DUI", duiCliente ?? (object)DBNull.Value); // Manejo del DUI opcional

                    int pedidoId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insertar en la tabla de pagos
                    if (metodoPago == "Efectivo")
                    {
                        string insertPagoEfectivo = @"
    INSERT INTO Pago_efectivo (pedido, Total, Cliente)
    VALUES (@PedidoID, @Total, @Cliente);";
                        MySqlCommand cmdPagoEfectivo = new MySqlCommand(insertPagoEfectivo, con);
                        cmdPagoEfectivo.Parameters.AddWithValue("@PedidoID", pedidoId);
                        cmdPagoEfectivo.Parameters.AddWithValue("@Total", totalPedido);
                        cmdPagoEfectivo.Parameters.AddWithValue("@Cliente", nombreCliente);
                        cmdPagoEfectivo.ExecuteNonQuery();
                    }
                    else if (metodoPago == "Tarjeta")
                    {
                        string insertPagoTarjeta = @"
    INSERT INTO Pago_tarjeta (pedido, Total, Cliente, DUI_cliente)
    VALUES (@PedidoID, @Total, @Cliente, @DUI);";
                        MySqlCommand cmdPagoTarjeta = new MySqlCommand(insertPagoTarjeta, con);
                        cmdPagoTarjeta.Parameters.AddWithValue("@PedidoID", pedidoId);
                        cmdPagoTarjeta.Parameters.AddWithValue("@Total", totalPedido);
                        cmdPagoTarjeta.Parameters.AddWithValue("@Cliente", nombreCliente);
                        cmdPagoTarjeta.Parameters.AddWithValue("@DUI", duiCliente ?? (object)DBNull.Value); // Manejo del DUI opcional
                        cmdPagoTarjeta.ExecuteNonQuery();
                    }

                    MessageBox.Show("Factura guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgfactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
*/