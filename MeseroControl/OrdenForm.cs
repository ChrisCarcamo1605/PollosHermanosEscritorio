using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using PollosHermanosRP.Logica;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PollosHermanosRP
{
    public partial class OrdenForm : Form
    {
        private Tipodepago tipodepago;
        private int propina;
        public static DataGridViewRow row;

        private ProductoBotones btn;

        public OrdenForm()
        {
            InitializeComponent();
            btn = new ProductoBotones(dtgProductos, lblTotal);  // Pasar el DataGridView y el Label al constructor
        }
        public OrdenForm(string cliente, string noMesa, string mesero) : this()
        {
            lblMesero.Text = mesero;
            lblCliente.Text = cliente;
            lblMesa.Text = noMesa;
           
        }

        public OrdenForm(int Propina) : this()
        {
            propina = Propina;
        }
        private void OrdenForm_Load(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Platillos", "Nombre", "Plato Fuerte");
            dtgProductos.Columns["Precio"].DefaultCellStyle.Format = "0.00";



        }

        public decimal ActualizarTotal()
        {
            decimal total = 0.00m;

            foreach (DataGridViewRow row in dtgProductos.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Subtotal"].Value != null)
                {
                    decimal subtotal;
                    string subtotalTexto = row.Cells["Subtotal"].Value.ToString().Replace("$", "").Replace(",", ".");
                    if (decimal.TryParse(subtotalTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out subtotal))
                    {
                        total += subtotal;
                    }
                    else
                    {
                        MessageBox.Show("El subtotal en una de las filas no tiene un formato válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            lblTotal.Text = total.ToString("C2");
            return total;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnEntradas_Click(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Platillos", "Nombre", "Plato Entrada");
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Platillos", "Nombre", "Postre");
        }

        private void btnBebidasCalientes_Click(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Bebidas", "Nombre", "Bebida Caliente");
        }

        private void btnBebidasFrias_Click(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Bebidas", "Nombre", "Bebida Fria");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgProductos.SelectedRows[0];
                if (selectedRow.Cells["Cantidad"].Value != null &&
                    !string.IsNullOrEmpty(selectedRow.Cells["Cantidad"].Value.ToString()))
                {
                    try
                    {
                        // Leer la cantidad actual
                        int cantidad = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);
                        cantidad--;

                        if (cantidad > 0)
                        {
                            // Actualizar la cantidad y el subtotal en la fila
                            selectedRow.Cells["Cantidad"].Value = cantidad;

                            // Asegúrate de que la celda "Precio" tenga un valor válido antes de usarlo
                            if (selectedRow.Cells["Precio"].Value != null)
                            {
                                decimal precio;
                                string precioTexto = selectedRow.Cells["Precio"].Value.ToString().Replace("$", "").Replace(",", ".");
                                if (decimal.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out precio))
                                {
                                    selectedRow.Cells["Subtotal"].Value = precio * cantidad;
                                }
                                else
                                {
                                    MessageBox.Show("El precio no tiene un formato válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            // Eliminar la fila si la cantidad llega a 0
                            dtgProductos.Rows.Remove(selectedRow);
                        }

                        // Actualizar el total (asegúrate de que este método esté implementado correctamente)
                        ActualizarTotal();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La celda de Cantidad está vacía o no es válida. Verifique los datos en la fila seleccionada.", "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private string ObtenerDescripcionPedido()
        {
            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in dtgProductos.Rows)
            {
                if (row.IsNewRow) continue;
                string nombre = row.Cells["Nombre"].Value.ToString();
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                sb.AppendLine($"{nombre} x{cantidad}");
            }

            return sb.ToString();
        }

        private void btnenviarorden_Click(object sender, EventArgs e)
        {
            int mesero = 1;
            if (lblMesero.Text == "N/A") { mesero = 1; } else { mesero = obtenerIdMesero(lblMesero.Text); }
            string cliente = lblCliente.Text;
            int mesa = 1;
            if (lblMesero.Text == "N/A") { mesero = 1; } else { mesero = obtenerIdMesero(lblMesero.Text); }
             obtenerIdMesa(lblMesa.Text);
            decimal total = PedidoControlador.CalcularTotal(dtgProductos);
            int id = PedidoControlador.GuardarPedido(dtgProductos, mesero, cliente, mesa, total);

            this.Close();
            


        }

        private void dtgfactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void dtgElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPlatosFuertes_Click_1(object sender, EventArgs e)
        {
            btn.DibujarBotonesProductos(flowLayoutPanel1, "Platillos", "Nombre", "Plato Fuerte");
        }

        private int obtenerPedido(int mesa)
        {
            int id = 0;


            string mesero = "N/A";
            try
            {
                Conexion.Abrir();

                string consulta = $"select id from pedido where Nomesa={mesa}";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);

                MySqlDataReader mySqlDataReader = comando.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    mesero = mySqlDataReader.GetString("nombre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ESTE" + ex.Message);

            }
            finally
            {
                Conexion.Cerrar();

            }
            return id;


        }

        public static string obtenerMesero(string contra)
        {
            string mesero = "N/A";
            try
            {
                Conexion.Abrir();

                string consulta = "select nombre from funcionario where contrasena=@contra;";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@contra", contra);

                MySqlDataReader mySqlDataReader = comando.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    mesero = mySqlDataReader.GetString("nombre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ESTE1" + ex.Message);

            }
            finally
            {
                Conexion.Cerrar();

            }

            return mesero;
        }



        public static int obtenerIdMesero(string nombre)
        {
            int id = 1;
            try
            {
                Conexion.Abrir();

                string consulta = "select id from funcionario where nombre = @nombre;";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@nombre", nombre);
                MySqlDataReader mySqlDataReader = comando.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    id = mySqlDataReader.GetInt16("id");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ORDEN" + ex.Message);
            }
            finally
            {
                Conexion.Cerrar();

            }

            return id;
        }
        public static int obtenerIdMesa(string noMesa)
        {
            int id = 0;
            try
            {
                Conexion.Abrir();

                string consulta = "Select id from mesa where NoMesa = @NoMesa;";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@NoMesa", noMesa);
                MySqlDataReader mySqlDataReader = comando.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    id = mySqlDataReader.GetInt16("id");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ORDEN" + ex.Message);

            }
            finally
            {
                Conexion.Cerrar();

            }

            return id;
        }

        private void lblMesero_Click(object sender, EventArgs e)
        {

        }

        private void lblpropina_Click(object sender, EventArgs e)
        {

        }
    }
    public class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
