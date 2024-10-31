using System;
using System.Resources;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PollosHermanosRP
{
    public partial class formPrincipal : Form
    {
        private Adminterminal adminterminal;

        public formPrincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //pago mixto
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Agregarnumero(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Agregarnumero(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Agregarnumero(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Agregarnumero(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Agregarnumero(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Agregarnumero(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Agregarnumero(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Agregarnumero(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Agregarnumero(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Agregarnumero(0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBoxCodigo.Clear();
        }

        private void btnCuentaNueva_Click(object sender, EventArgs e)
        {
            // Obtén la contraseña ingresada en la caja de texto
            string contraseñaIngresada = txtBoxCodigo.Text;

            // Llama al método para verificar la contraseña y abrir el formulario correspondiente
            Verificarcontra(contraseñaIngresada, new MesasForm(txtBoxCodigo.Text, 0));

            txtBoxCodigo.Clear();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            string admincontra = "0000";
            if (txtBoxCodigo.Text != admincontra)
            {
                MessageBox.Show("Contrasena de administrador incorrecta");
            }
            else
            {
                this.Hide();
                Adminterminal adminterminal = new Adminterminal();
                adminterminal.Show();
                adminterminal.FormClosed += (s, args) => this.Show();
            }

        }
        private void btnOrdenLlevar_Click(object sender, EventArgs e)
        {
            txtBoxCodigo.Clear();
            this.Hide();
            
            OrdenForm ordenForm = new OrdenForm();  
            ordenForm.Show();
            ordenForm.FormClosed += (s, args) => this.Show(); ordenForm.FormClosed += (s, args) => this.Show();
            
        }


        private void Agregarnumero(int number)
        {
            txtBoxCodigo.Text += number.ToString();
        }

        private void OpenForm(Form form)
        {
            form.Show();
            form.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        public string cargarTxtBox()
        {
            return txtBoxCodigo.Text;
        }

        private void Verificarcontra(string password, Form formToOpen)
        {
            string connectionString = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM FUNCIONARIO WHERE contrasena = @contrasena AND Activo = 1";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@contrasena", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Contraseña válida, abre el formulario
                        OpenForm(formToOpen);

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta o cuenta inactiva.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void txtBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCuentaExistente_Click(object sender, EventArgs e)
        {
            string contraseñaIngresada = txtBoxCodigo.Text;


            Verificarcontra(contraseñaIngresada, new MesasForm(txtBoxCodigo.Text, 1));
            txtBoxCodigo.Clear();
        }
    }
}
