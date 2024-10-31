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
    public partial class Bebida : Form
    {
        public bool IsFriaChecked => chkfria.Checked;
        public bool IsCalienteChecked => chkcaliente.Checked;

        public Bebida()
        {
            InitializeComponent();
        }

        public void chkfria_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfria.Checked)
            {
                // Desmarcar el otro CheckBox
                if (IsCalienteChecked)
                {
                    chkcaliente.Checked = false;
                }
            }
        }

        public void chkcaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcaliente.Checked)
            {
                // Desmarcar el otro CheckBox
                if (IsFriaChecked)
                {
                    chkfria.Checked = false;
                }
            }
        }
    }
}
