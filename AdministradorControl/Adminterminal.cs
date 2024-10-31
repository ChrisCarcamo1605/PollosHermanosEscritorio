using Org.BouncyCastle.Tls;
using PollosHermanosRP.AdministradorControl;
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
    public partial class Adminterminal : Form
    {
        private GestionMenu addelement;
        private GestionEmpleados Añadirempleado;
        private Controlventas controlventas;
        private Controlpedidos controlpedidos;
        public Adminterminal()
        {
            InitializeComponent();
        }

        private void btnabrirmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionMenu addelement = new GestionMenu();
            addelement.Show();
            addelement.FormClosed += (s, args) => this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnabrirempleados_Click(object sender, EventArgs e)
        {
            GestionEmpleados añadirempleado = new GestionEmpleados();
            añadirempleado.ShowDialog();
        }

        private void Adminterminal_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionMesas mesas = new GestionMesas();
            mesas.Show();
            mesas.FormClosed += (s, args) => this.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controlventas controlventas = new Controlventas();
            controlventas.Show();
            controlventas.FormClosed += (s, args) => this.Show();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controlpedidos controlpedidos = new Controlpedidos();
            controlpedidos.Show();
            controlpedidos.FormClosed += (s, args) => this.Show();
        }
    }
}
