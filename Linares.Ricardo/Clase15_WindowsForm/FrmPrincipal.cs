using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase15_WindowsForm
{
    public partial class FrmPrincipal : Form
    {
        private string _domain;
        private OpenFileDialog _openFileDialog;
        public FrmPrincipal()
        {

            InitializeComponent();
            this._domain =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\NewText.txt";
            this._openFileDialog = new OpenFileDialog();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamWriter writer = new StreamWriter(this._domain, true);
                if(this.txtValor.Text != "" && this.txtValor.Text != null)
                {
                    writer.WriteLine(this.txtValor.Text);
                    if (this.lstVisor.Items.Contains(((FileStream)(writer.BaseStream)).Name) != true)
                    {
                        this.lstVisor.Items.Add(((FileStream)(writer.BaseStream)).Name);
                    }
                }
                else
                {
                    writer.Close();
                    throw new Exception("Debe llenar el textBox con texto");
                }
                writer.Close();

            }
            catch (Exception exception)
            {

                this.Error(exception);
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamReader reader = new StreamReader((string)this.lstVisor.SelectedItem);
                string lines = reader.ReadToEnd();

                this.txtValor.Text = lines;
                reader.Close();
            }
            catch (Exception exception)
            {
                this.Error(exception);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this._openFileDialog.DefaultExt = "*.txt";
                this._openFileDialog.AddExtension = true;
                this._openFileDialog.Filter = "txt files (*.txt)|*.txt";
                this._openFileDialog.FilterIndex = 1;
                DialogResult n = this._openFileDialog.ShowDialog();
                if (n == DialogResult.OK)
                {
                    this._domain = this._openFileDialog.FileName;
                    if (this.lstVisor.Items.Contains(this._domain) != true)
                        this.lstVisor.Items.Add(this._domain);
                }
            }
            catch (Exception exception)
            {
                this.Error(exception);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this._openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this._openFileDialog.Title = "Abre un archivo .Txt";
        }

        private void Error(Exception e)
        {
            MessageBox.Show(e.Message, "error");
        }
    }
}
