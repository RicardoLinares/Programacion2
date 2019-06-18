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
    public partial class FrmTest2 : Form
    {
        Mensajeadora a;
        public FrmTest2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Init);
            // los delegados pueden tener instancias de ellos
            // con del.invoke se puede invocar el metodo del delegado
            // tambien se puede hacer implicitamente como si fuera cualquier otro metodo del(int, int);
        }

        public void Init(object sender, EventArgs e)
        {
            a = new Mensajeadora();

            this.btnBoton1.Click += this.Manejador;

        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            
        }
        public void Manejador(object sander, EventArgs i)
        {
            if(sander is Button)
            {
                Button sender = (Button)sander;
                MessageBox.Show(sender.Name);
                if (sender == this.btnBoton1)
                {
                    this.btnBoton1.Click -= new EventHandler(Manejador);
                    this.btnBoton2.Click += new EventHandler(Manejador);
                }
                else if (sender == this.btnBoton2)
                {
                    this.btnBoton2.Click -= new EventHandler(Manejador);
                    this.btnBoton3.Click += new EventHandler(Manejador);
                }
                else if (sender == this.btnBoton3)
                {
                    this.btnBoton3.Click -= new EventHandler(Manejador);
                    this.btnBoton1.Click += new EventHandler(Manejador);
                }
            }
        }

        public void FrmTest2_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado del = new MiDelegado(Mensajeadora.Sumar);
            del(1, 2);
            MiDelegado del2 = new MiDelegado(a.Restar);
            del2(1, 2);
            MiDelegado delegadoConbinado = (MiDelegado)MiDelegado.Combine(del,del2);
            delegadoConbinado(3, 2);
            /// delegadoConbinado.GetInvocationList()[0].Target te trae el primer elemento de la lista de invocacion
            /// delegadoCombinado.GetInvocationList()
            MiDelegado del4 = (MiDelegado)MiDelegado.Combine(delegadoConbinado, new MiDelegado(a.Multiplicar));
            del4(4, 5);
            Mensajeadora.OtraSuma(del4, 4, 4);
        }
    }

}
