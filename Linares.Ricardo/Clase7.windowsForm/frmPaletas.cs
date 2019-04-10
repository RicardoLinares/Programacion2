using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmTempera;
namespace Clase7.windowsForm
{
    public partial class frmPaletas : Form
    {
        string resultado;
        public frmPaletas()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera.frmTempera frmTempera = new frmTempera.frmTempera();
            frmTempera.ShowDialog();
            if(DialogResult.OK == frmTempera.DialogResult)
            {
                this.resultado = frmTempera.resultadoStr;
                this.checkedListBox1.Items.Add(frmTempera.resultadoStr);
            }
        }

        private void frmPaletas_Load(object sender, EventArgs e)
        {

        }
    }
}
