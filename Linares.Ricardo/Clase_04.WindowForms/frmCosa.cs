using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04.Entidades;
namespace Clase_04.WindowForms
{
    public partial class FrmCosa : Form
    {
        //antes de empezar
        public FrmCosa()
        {
            InitializeComponent();

        }
        // primer evento... no se repite solo una vez
        private void frmCosa_Load(object sender, EventArgs e)
        {

            MessageBox.Show("HOLA MUNDO", "HOLA MUNDO");
            Cosa cosa = new Cosa();
            MessageBox.Show(cosa.Mostrar(), Cosa.Mostrar(cosa));
        }
        // segundo evento... se repite todas las veces necesarias No recomendado pinta el formularios
        private void FrmCosa_Paint(object sender, PaintEventArgs e)
        {

        }
        // tercer evento... se repite las veces necesarias. No recomendado. se activa cuando tiene foco del formulario
        private void FrmCosa_Activated(object sender, EventArgs e)
        {
        }
        // ----------------------

        // al ahora de terminar hacer click en la X, oportunidad de cancelacion, Se pede repetir. Recomendado programar ventanas
        // de confirmacion
        private void FrmCosa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        //cierre del formulario, no se repite. 
        private void FrmCosa_FormClosed(object sender, FormClosedEventArgs e)
        {

            MessageBox.Show("Saliendo del Programa", "Salida");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa cosa = new Cosa(777,new DateTime(7777,7,7), "Seven");
            MessageBox.Show(cosa.Mostrar(), Cosa.Mostrar(cosa));
            this.button1.Text = "Crear Cosa Bonita";
            this.Text = "Cosa Bonita";
            Color lol = Color.Fuchsia;
            int asd;
            string newColor = "FF51382C"; // FF - A -, 51 - R, 82 - G, 2C - B; 
            asd = int.Parse(newColor, System.Globalization.NumberStyles.HexNumber);

            this.Text = asd.ToString("X");
            this.BackColor = Color.FromArgb(asd);
        }

        // evento final Dispose, se llama una vez
    }
}
