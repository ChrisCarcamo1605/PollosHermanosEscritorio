using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PollosHermanosRP
{
    /*private decimal total;
    private List<Tuple<decimal, string, string>> pagos = new List<Tuple<decimal, string, string>>(); // Monto, método, DUI
    public partial class PagoMixtoForm : Form
    {
        public PagoMixtoForm()
        {
            InitializeComponent();
            this.total = total;
            lblTotal.Text = $"Total a Pagar: {total:C}";
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {

            decimal monto = Convert.ToDecimal(txtMonto.Text);
            string metodo = cmbMetodoPago.SelectedItem.ToString();
            string duiCliente = txtDui.Text;

            if (monto <= 0 || monto > total)
            {
                MessageBox.Show("Monto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (metodo == "Tarjeta" && string.IsNullOrEmpty(duiCliente))
            {
                MessageBox.Show("DUI del cliente requerido para pago con tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pagos.Add(new Tuple<decimal, string, string>(monto, metodo, duiCliente));
            total -= monto;

            if (total <= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblTotal.Text = $"Total Restante: {total:C}";
                txtMonto.Clear();
                txtDui.Clear();
            }
        }
    }
}
    */
}