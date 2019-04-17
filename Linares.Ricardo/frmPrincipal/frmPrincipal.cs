using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase7.windowsForm;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPaletas frmPaletas = new frmPaletas();

            frmPaletas.MdiParent = this;

            frmPaletas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs cerrado = new FormClosingEventArgs(CloseReason.UserClosing, false);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Estas seguro de cerrar el formulario?", "Estas seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
