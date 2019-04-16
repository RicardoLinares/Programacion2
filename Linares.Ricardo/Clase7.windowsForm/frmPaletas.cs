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
using Entidades;
namespace Clase7.windowsForm
{
    public partial class frmPaletas : Form
    {
        public Paleta _paleta;
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
                if(this._paleta + frmTempera.nuevaTempera)
                {
                    this.lstLista.Items.Add(frmTempera.nuevaTempera.Mostrar());
                }
            }
        }

        private void frmPaletas_Load(object sender, EventArgs e)
        {
            this._paleta = new Paleta(10);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int index = this.lstLista.SelectedIndex;
            if(-1 != index)
            {
                frmTempera.frmTempera frmTempera = new frmTempera.frmTempera(this._paleta._listTempera[index]);

                frmTempera.ShowDialog();
                if (DialogResult.OK == frmTempera.DialogResult)
                {
                    if (this._paleta + frmTempera.nuevaTempera)
                    {
                        this.lstLista.Items.Add(frmTempera.nuevaTempera.Mostrar());
                    }
                }

            }
        }
    }
}
