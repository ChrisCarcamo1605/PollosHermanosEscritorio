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
    public partial class Tipodepago : Form
    {

        private decimal total;
     
        public string MetodoDePago { get; private set; }

        public Tipodepago(decimal total)
        {
            InitializeComponent();
            this.total = total;
            // Aquí puedes usar la variable total para mostrar el total en el formulario
            lblTotal.Text = $"Total a Pagar: {total:C}";
        }

        private void Tipodepago_Load(object sender, EventArgs e)
        {
            // Supongamos que tienes un Label llamado lblTotal en Tipodepago
            lblTotal.Text = $"Total a Pagar: {total:C}";
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnCuentaExistente_Click(object sender, EventArgs e)
        {
          
        }

        private void btnpagoefectivo_Click(object sender, EventArgs e)
        {
            MetodoDePago = "Efectivo"; // Establece el método de pago como efectivo
            this.DialogResult = DialogResult.OK; // Cierra el formulario con resultado OK
            this.Close(); // Cierra el formulario

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
