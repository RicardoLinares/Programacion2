using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace frmTempera
{
    public partial class frmTempera : Form
    {
        public string resultadoStr;
        public frmTempera()
        {
            InitializeComponent();

            this.cboColor.Items.Add("*");
            this.cboColor.Items.Add("/");
            this.cboColor.Items.Add("+");
            this.cboColor.Items.Add("-");
            this.cboColor.SelectedIndex = 1;
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero(this.txtMarca.Text);
            Numero n2 = new Numero(this.txtCant.Text);
            double resultado = Calculadora.Operar(n1, n2, this.cboColor.SelectedItem.ToString());
            MessageBox.Show(n1.ToString()+ " " + this.cboColor.SelectedItem.ToString()+ " " + n2.ToString() + " = " + resultado);
            resultadoStr = n1.ToString() + " " + this.cboColor.SelectedItem.ToString() + " " + n2.ToString() + " = " + resultado.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void frmTempera_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
