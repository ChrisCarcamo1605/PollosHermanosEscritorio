using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using PollosHermanosRP.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;

namespace PollosHermanosRP
{
    public partial class GestionEmpleados : Form

    {



        public bool iscocinero => chkcocinero.Checked;
        public bool ismesero => chkmesero.Checked;
        public bool islimpieza => chklimpieza.Checked;
        public bool iscajero => chkcajero.Checked;
        private void Añadirempleado_Load(object sender, EventArgs e)
        {
            imprimirDatos();
        }
        private bool ValidateInputs(out string rol)
        {
            rol = "";

            string nombre = txtnombre.Text.Trim();
            string sueldoText = txtsueldo.Text.Trim();
            string contrasena = txtcontrasena.Text.Trim();

            // Validar el nombre
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar el sueldo
            if (string.IsNullOrEmpty(sueldoText) || !decimal.TryParse(sueldoText, out decimal sueldo) || sueldo <= 0)
            {
                MessageBox.Show("Por favor, ingrese un sueldo válido mayor que 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar el rol
            if (!chkmesero.Checked && !chkcajero.Checked && !chkcocinero.Checked && !chklimpieza.Checked)
            {
                MessageBox.Show("Por favor, seleccione un rol para el empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Asignar el rol basado en las casillas de verificación
            if (chkmesero.Checked)
            {
                rol = "Mesero";
            }
            else if (chkcajero.Checked)
            {
                rol = "Cajero";
            }
            else if (chkcocinero.Checked)
            {
                rol = "Cocinero";
            }
            else if (chklimpieza.Checked)
            {
                rol = "Limpieza";
            }

            // Validar la contraseña según el rol
            if (rol == "Mesero")
            {
                if (string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("Los meseros deben tener contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                // Si el rol no es "Mesero", asegúrate de que la contraseña esté vacía
                if (!string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("Los roles que no sean mesero no deben tener contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Todos los datos son válidos
            return true;
        }


        public GestionEmpleados()
        {
            InitializeComponent();
        }
        public void imprimirDatos()
        {
            try
            {
                Conexion.Cerrar();
                string consulta = "SELECT * FROM FUNCIONARIO";
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, Conexion.conexion);
                DataTable dt1 = new DataTable();
                comando.Fill(dt1);
                dtgempleados.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Conexion.Cerrar(); }
        }



        private void chkcajero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcajero.Checked)
            {
                if (ismesero || islimpieza || iscocinero)
                {
                    chkmesero.Checked = false;
                    chklimpieza.Checked = false;
                    chkcajero.Checked = false;
                }
            }
        }
        public void chkcocinero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcocinero.Checked)
            {
                if (ismesero || islimpieza || iscajero)
                {
                    chkmesero.Checked = false;
                    chklimpieza.Checked = false;
                    chkcajero.Checked = false;
                }
            }
        }

        private void chkmesero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmesero.Checked)
            {
                if (iscocinero || islimpieza || iscajero)
                {
                    chkcocinero.Checked = false;
                    chklimpieza.Checked = false;
                    chkcajero.Checked = false;
                }
            }
        }

        private void chklimpieza_CheckedChanged(object sender, EventArgs e)
        {
            if (chklimpieza.Checked)
            {
                if (ismesero || iscocinero || iscajero)
                {
                    chkmesero.Checked = false;
                    chkcocinero.Checked = false;
                    chkcajero.Checked = false;
                }
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != 32))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtsueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtprice = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && txtprice.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            if (txtprice.Text.Contains("."))
            {
                string[] splitText = txtprice.Text.Split('.');
                if (splitText.Length > 1 && splitText[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out string rol))
            {
                // Obtener los datos de los controles
                string nombre = txtnombre.Text.Trim();
                string sueldoText = txtsueldo.Text.Trim();
                string contrasena = txtcontrasena.Text.Trim();
                decimal sueldo = decimal.Parse(sueldoText);

                try
                {
                    Conexion.Abrir();
                    string consulta = "INSERT INTO FUNCIONARIO (Nombre, tipo, contrasena, sueldo, activo) VALUES (@nombre, @tipo, @contrasena, @sueldo, @activo)";
                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@tipo", rol);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);
                    comando.Parameters.AddWithValue("@sueldo", sueldo);
                    comando.Parameters.AddWithValue("@activo", 1); // Si el campo activo está en 1 (activo)

                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Conexion.Cerrar();
                }

                imprimirDatos();

                // Limpiar los controles
                txtnombre.Clear();
                txtcontrasena.Clear();
                txtsueldo.Clear();
                chkmesero.Checked = false;
                chkcajero.Checked = false;
                chklimpieza.Checked = false;
                chkcocinero.Checked = false;



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

            try
            {
                Conexion.Abrir();

                // Consulta SQL para buscar en la tabla FUNCIONARIO
                string consulta = @"
            SELECT ID, Nombre, tipo, sueldo, contrasena, activo 
            FROM FUNCIONARIO 
            WHERE CONCAT_WS(' ', Nombre, tipo, sueldo, contrasena) LIKE @TextoBuscar";

                using (MySqlCommand comando = new MySqlCommand(consulta, Conexion.con))
                {
                    comando.Parameters.AddWithValue("@TextoBuscar", "%" + textoBuscar + "%");

                    // Depuración: Verificar la consulta SQL
                    Console.WriteLine("Consulta SQL: " + consulta);
                    Console.WriteLine("Texto de búsqueda: " + textoBuscar);

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable resultados = new DataTable();
                    adaptador.Fill(resultados);

                    // Depuración: Verificar el número de filas obtenidas
                    Console.WriteLine("Número de filas obtenidas: " + resultados.Rows.Count);

                    // Asignar los resultados al DataGridView
                    dtgempleados.DataSource = resultados;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }
        }




        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ActualizarRegistro(string columna, string registroNuevo, int id)
        {
            try
            {
                Conexion.Abrir();
                string consulta = "UPDATE FUNCIONARIO SET " + columna + " = @registroNuevo WHERE ID = @id";
                MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@registroNuevo", registroNuevo);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.Cerrar();
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (dtgempleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dtgempleados.SelectedRows[0];

            // Obtener el ID del funcionario seleccionado
            int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

            // Validar los datos de entrada
            if (ValidateInputs(out string rol))
            {
                // Obtener los datos de los controles
                string nombre = txtnombre.Text.Trim();
                string sueldoText = txtsueldo.Text.Trim();
                string contrasena = txtcontrasena.Text.Trim();
                decimal sueldo = decimal.Parse(sueldoText);

                // Actualizar los datos en la base de datos
                if (!string.IsNullOrEmpty(nombre))
                {
                    ActualizarRegistro("Nombre", nombre, id);
                }
                if (!string.IsNullOrEmpty(contrasena))
                {
                    ActualizarRegistro("contrasena", contrasena, id);
                }
                if (sueldo > 0)
                {
                    ActualizarRegistro("sueldo", sueldo.ToString(), id);
                }
                if (!string.IsNullOrEmpty(rol))
                {
                    ActualizarRegistro("tipo", rol, id);
                }

                // Actualizar el DataGridView
                imprimirDatos();

                // Limpiar los controles
                txtnombre.Clear();
                txtcontrasena.Clear();
                txtsueldo.Clear();
                chkmesero.Checked = false;
                chkcajero.Checked = false;
                chklimpieza.Checked = false;
                chkcocinero.Checked = false;
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dtgempleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dtgempleados.SelectedRows[0];

            // Obtener el ID del funcionario seleccionado
            int id = Convert.ToInt32(filaSeleccionada.Cells["ID"].Value);

            // Confirmar la eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Eliminar el registro
                try
                {
                    Conexion.Cerrar();
                    string consulta = "DELETE FROM FUNCIONARIO WHERE ID = @id";
                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.con);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexion.Cerrar();
                }

                // Actualiza el dtg
                imprimirDatos();

                // Limpiar los controles
                txtnombre.Clear();
                txtcontrasena.Clear();
                txtsueldo.Clear();
                chkmesero.Checked = false;
                chkcajero.Checked = false;
                chklimpieza.Checked = false;
                chkcocinero.Checked = false;
            }
        }

        private void txtcontrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
} 
