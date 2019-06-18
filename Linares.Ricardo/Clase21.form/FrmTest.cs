using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase21.form
{
    
    public partial class FrmTest : Form
    {
        FrmTest2 form2;
        private Mensajeadora mensajeadora;
        public FrmTest()
        {
            InitializeComponent();
            form2 = new FrmTest2();
            this.btnButton.Click += this.CrearSegundo;
            this.btnButton.Click += form2.FrmTest2_Load;
            this.lblEtiqueta.Click += Mensajeadora.Mensajeador;
            this.btnButton.Click += Mensajeadora.Mensajeador;
            this.txtCuadroTexto.Click += Mensajeadora.Mensajeador;
            this.mensajeadora = new Mensajeadora();
            this.lblEtiqueta.Click += this.mensajeadora.Meep;
            this.btnButton.Click += this.mensajeadora.Meep;
            this.txtCuadroTexto.Click += this.mensajeadora.Meep;
        }
        private void CrearSegundo(object sender, EventArgs e)
        {
            this.form2 = new FrmTest2();
        }
        //private void MostrarMensaje(object sender, EventArgs e)
        //{
        //    MessageBox.Show("EVENTO DE BOTON");
        //  //  this.lblEtiqueta.Click += new System.EventHandler(this.lblEtiqueta_Click);
        //  //  this.txtCuadroTexto.Click += new System.EventHandler(this.txtCuadroTexto_Click);
        //}

        //private void lblEtiqueta_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show(DateTime.Now.ToLongDateString());
        //    //this.lblEtiqueta.Click -= new System.EventHandler(this.lblEtiqueta_Click);
        //}

        // manejador de evento de objetos
        // trae una invocacion de un delegado con firma
        // ModVisibilidad void Nombre(Objecto enviador, EventArgs evento)
        //private void txtCuadroTexto_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("EVENTO DE TEXTO");
        //}
    }
}
