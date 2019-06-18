using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Clase21.form
{
    public class Mensajeadora
    {
        // Sender = objeto que activo el evento,
        // EventArgs = Informacion especifica de el evento
        public static void Mensajeador(Object sender, EventArgs e)
        {
            MessageBox.Show("Evento de masaje");
        }
        public static void Sumar(int a, int b)
        {

            MessageBox.Show((a+b).ToString());
        }
        public static void OtraSuma(MiDelegado delegado, int a, int b)
        {
            delegado(a, b);
        }
        public void Restar(int a, int b)
        {

            MessageBox.Show((a - b).ToString());
        }
        public void Multiplicar(int a, int b)
        {

            MessageBox.Show((a * b).ToString());
        }
        public void Meep(Object sander, EventArgs i)
        {
            
            if(sander is Button)
            {

                MessageBox.Show("Evento de Boton");
            }
            else if(sander is Label)
            {
                MessageBox.Show("Evento de Label");

            }
            else if(sander is TextBox)
            {
                MessageBox.Show("Evento de TextBox");
            }
        }
    }
}
