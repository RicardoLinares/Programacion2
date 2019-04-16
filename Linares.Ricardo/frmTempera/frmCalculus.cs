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
        public Tempera nuevaTempera;
        public frmTempera()
        {
            InitializeComponent();
            Array color = Enum.GetValues(typeof(ConsoleColor));
            foreach (object colores in color)
            {
                cboColor.Items.Add((ConsoleColor)colores);
            }
            this.cboColor.SelectedIndex = 0;


        }
        public frmTempera(Tempera tempera) : this()
        {
            this.txtMarca.Text = tempera.MiMarca;
            this.txtMarca.Enabled = false;
            this.cboColor.SelectedItem = this.cboColor.Items.IndexOf(tempera.MiColor);
            this.cboColor.Enabled = false;
            this.txtCant.Text = tempera.Cantidad.ToString();
            this.txtMarca.Enabled = false;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantidad;
            Int32.TryParse(txtCant.Text, out cantidad);
            nuevaTempera = new Tempera(txtMarca.Text, (ConsoleColor)cboColor.SelectedItem, cantidad);
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
