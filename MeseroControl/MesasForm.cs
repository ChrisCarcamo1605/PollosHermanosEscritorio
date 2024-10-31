using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PollosHermanosRP.AdministradorControl;
using PollosHermanosRP.Logica;

namespace PollosHermanosRP
{
    public partial class MesasForm : Form
    {
        static string contra;
        int cuenta = 0;
        
        public MesasForm()
        {
            InitializeComponent();
        }
        public MesasForm(string contraMesero, int Cuenta) : this() {

            contra = contraMesero;
            cuenta = Cuenta;

        }

        public MesasForm(int Cuenta) : this()
        {
            cuenta = Cuenta;

        }
        static string nombre = OrdenForm.obtenerMesero(contra);

        private void cargarMesasOcupadas(string area)
        {
            int id = OrdenForm.obtenerIdMesero(OrdenForm.obtenerMesero(contra));
            MesasBotones.dibujarMesas(flowLayoutPanel1, id, area);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void MesasForm_Load(object sender, EventArgs e)
        {
            cargarMesasOcupadas("a");
        }
        

        private void btnA_Click(object sender, EventArgs e)
        {
            if (cuenta == 0)
            {
                MesasBotones.dibujarMesas(flowLayoutPanel1, "A");
            }
            else { cargarMesasOcupadas("A"); }

        }

        public void abrirForm(Form form)
        {
            flowLayoutPanel1.Controls.Clear();
            form.TopLevel = false;
            flowLayoutPanel1.Controls.Add(form);
            form.Show();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (cuenta == 0)
            {
                MesasBotones.dibujarMesas(flowLayoutPanel1, "B");
            }
            else { cargarMesasOcupadas("B"); }

        }



        private void btnC_Click(object sender, EventArgs e)
        {

            if (cuenta == 0)
            {
                MesasBotones.dibujarMesas(flowLayoutPanel1, "C");
            }
            else { cargarMesasOcupadas("C"); }
        }

        private void btnD_Click(object sender, EventArgs e)
        {

            if (cuenta == 0)
            {
                MesasBotones.dibujarMesas(flowLayoutPanel1, "D");
            }
            else { cargarMesasOcupadas("D"); }
        }

        private void btnE_Click(object sender, EventArgs e)
        {

            if (cuenta == 0)
            {
                MesasBotones.dibujarMesas(flowLayoutPanel1, "E");
            }
            else { cargarMesasOcupadas("E"); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void txtNumeroPersonas_TextChanged(object sender, EventArgs e)
        {
            if (txtNumeroPersonas.Text.Length > 2)
            {
                txtNumeroPersonas.Text = txtNumeroPersonas.Text.Substring(0, 2);
                txtNumeroPersonas.SelectionStart = txtNumeroPersonas.Text.Length;
            }
        }
        public static void SetValorNoMesa(string noMesa)
        {
            txtNumeroMesa.Text = noMesa;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numero = 1;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int numero = 2;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int numero = 3;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int numero = 4;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int numero = 5;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int numero = 6;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int numero = 7;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int numero = 8;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int numero = 9;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int numero = 0;
            txtNumeroPersonas.Text += numero.ToString();
        }

        private void txtNumeroPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void AsignacionMesa(int id)
        {
            

           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumeroPersonas.Clear();
        }

        private void txtNumeroMesa_TextChanged(object sender, EventArgs e)
        {

        }


        static bool estado = false;
        private void btnImprimirCuenta_Click(object sender, EventArgs e)
        {
            int id = OrdenForm.obtenerIdMesero(OrdenForm.obtenerMesero(contra));
           
            this.Hide();
            OrdenForm orden = new OrdenForm(txtNombreCliente.Text,txtNumeroMesa.Text,OrdenForm.obtenerMesero(contra));
            orden.FormClosed += (s, args) => this.Show();
            GestionMesas.desactivarMesa(OrdenForm.obtenerIdMesa(txtNumeroMesa.Text),id);
            
            orden.Show();

        }
    }
}
