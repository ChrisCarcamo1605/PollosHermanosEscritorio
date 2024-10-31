using MySql.Data.MySqlClient; 
using System;
using System.Data;
using System.Windows.Forms;

namespace PollosHermanosRP
{
    public partial class Controlventas : Form
    {
        //conexion a la base de datos
        private string conexion = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";

        public Controlventas()
        {
            InitializeComponent();
            CargarDatos();
        }
        //evento cargar datos
        private void CargarDatos()
        {
            try
            {
                //consulta SQL con INNER JOINs
                string consulta = @"
            SELECT 
                p.ID AS PedidoID,
                m.NoMesa AS NumeroMesa,
                p.Cliente,
                p.detallesPedido,
                p.fecha,
                f.Nombre AS Mesero,
                p.Total_a_pagar AS Total,
                p.Activo
            FROM
                Pedido p
            INNER JOIN
                Mesa m ON p.NumeroMesa = m.ID
            INNER JOIN
                Funcionario f ON p.Mesero = f.ID
            WHERE
                p.Activo = '0'";

                using (MySqlConnection con = new MySqlConnection(conexion))
                using (MySqlDataAdapter comando = new MySqlDataAdapter(consulta, con))
                {
                    DataTable dt1 = new DataTable();
                    comando.Fill(dt1);
                    dtgventas.DataSource = dt1;
                }
                CalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        //evento cacular datos 
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dtgventas.Rows)
            {
                if (row.Cells["Total"].Value != DBNull.Value)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            lbltotal.Text = total.ToString("C2");
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
