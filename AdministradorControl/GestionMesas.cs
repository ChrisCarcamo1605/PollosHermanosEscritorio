using MySql.Data.MySqlClient;
using PollosHermanosRP.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PollosHermanosRP.AdministradorControl
{
    public partial class GestionMesas : Form
    {
        public GestionMesas()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GestionMesas_Load(object sender, EventArgs e)
        {
            cargarMesas();

        }
        private void cargarMesas()
        {
            try
            {
                Conexion.Abrir();
                string consulta = "SELECT * FROM mesa";
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, Conexion.conexion);
                DataTable dt1 = new DataTable();
                comando.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.Cerrar(); }
        }



        private void dtgMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static string area = "";
        private void cbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            string area = "";
            string noMesa = "";


            if (cbAreas.SelectedItem != null && txtNoMesa.Text != "")
            {
                area = cbAreas.SelectedItem.ToString();
                noMesa = area + txtNoMesa.Text;

                try
                {
                    Conexion.Abrir();

                    string consulta2 = "Select NoMesa from mesa where NoMesa = @NoMesa;";
                    MySqlCommand comando2 = new MySqlCommand(consulta2, Conexion.con);
                    comando2.Parameters.AddWithValue("@NoMesa", noMesa);
                    MySqlDataReader reader = comando2.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mesa ya existente, Por favor ingrese otro número", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        reader.Close();

                        // Insertar la nueva mesa
                        string consulta = "Insert into mesa(NoMesa, Area) Values(@NoMesa, @Area);";
                        MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                        comando.Parameters.AddWithValue("@Area", area);
                        comando.Parameters.AddWithValue("@NoMesa", noMesa);
                        comando.ExecuteNonQuery();

                        cargarMesas();
                        MessageBox.Show("Mesa agregada correctamente");
                        cbAreas.SelectedIndex = -1;
                        txtNoMesa.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MESA" + ex.Message);
                }
                finally
                {

                    Conexion.Cerrar();
                }
            }
            else
            {
                MessageBox.Show("Por favor, llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnEliminarMesa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

            // Obtener el ID del funcionario seleccionado
            int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

            // Confirmar la eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Eliminar el registro
                try
                {
                    Conexion.Abrir();
                    string consulta = "DELETE FROM mesa WHERE ID = @id";
                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MESA" + ex.Message);
                }
                finally
                {
                    Conexion.Cerrar();
                }

                cargarMesas();
            }



        }

        private void txtNoMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoMesa_TextChanged(object sender, EventArgs e)
        {
            if (txtNoMesa.Text.Length > 2)
            {
                txtNoMesa.Text = txtNoMesa.Text.Substring(0, 2);
                txtNoMesa.SelectionStart = txtNoMesa.Text.Length;
            }
        }


        public void activarDesactivarMesa()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para desactivar mesa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            var idCelda = filaSeleccionada.Cells[3].Value;
            int activo = Convert.ToInt16(idCelda);

            if (activo == 1) { activo = 0; } else { activo = 1; }
            int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

            // Confirmar la eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea desactivar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    Conexion.Abrir();
                    string consulta = "UPDATE MESA SET ACTIVO = @activo  WHERE ID = @id";
                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@activo", activo);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MESA" + ex.Message);
                }
                finally
                {
                    Conexion.Cerrar();
                }

                cargarMesas();


            }
        }


        public static void desactivarMesa(int mesa, int mesero)
        {

            try
            {
                Conexion.Abrir();
                string consulta = "UPDATE MESA SET ACTIVO = 0, mesero = @mesero  WHERE ID = @id;";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@id", mesa);
                comando.Parameters.AddWithValue("@mesero", mesero);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MESA" + ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            activarDesactivarMesa();
        }

    }
}
