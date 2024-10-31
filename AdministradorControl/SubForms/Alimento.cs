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
    public partial class Alimento : Form
    {
        public bool IsEntradaChecked => chkentrada.Checked;
        public bool IsPlatoFuerteChecked => chkplatofuerte.Checked;
        public bool IsPostreChecked => chkpostre.Checked;

        public Alimento()
        {
            InitializeComponent();
        }

        public void chkentrada_CheckedChanged(object sender, EventArgs e)
        {
            if (chkentrada.Checked)
            {
                // Desmarcar los otros CheckBox
                if (IsPlatoFuerteChecked || IsPostreChecked)
                {
                    chkpostre.Checked = false;
                    chkplatofuerte.Checked = false;
                }
            }
        }

        public void chkplatofuerte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkplatofuerte.Checked)
            {
                // Desmarcar los otros CheckBox
                if (IsEntradaChecked || IsPostreChecked)
                {
                    chkpostre.Checked = false;
                    chkentrada.Checked = false;
                }
            }
        }

        public void chkpostre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpostre.Checked)
            {
                // Desmarcar los otros CheckBox
                if (IsEntradaChecked || IsPlatoFuerteChecked)
                {
                    chkentrada.Checked = false;
                    chkplatofuerte.Checked = false;
                }
            }
        }

        private void Alimento_Load(object sender, EventArgs e)
        {

        }
    }
}
