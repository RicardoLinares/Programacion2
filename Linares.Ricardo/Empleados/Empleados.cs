using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase22.Entidades;
using System.IO;
namespace Empleados
{
    public partial class Empleados : Form
    {
        private EmpleadoMejorado Empleado;
        public Empleados()
        {
            InitializeComponent();
            this.Empleado = new EmpleadoMejorado();
            this.cmbTipo.Items.AddRange(Enum.GetNames(typeof(TipoManejador)));
            this.cmbTipo.SelectedIndex = 0;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Empleado._delSueldo -= new DelSueldo(Empleados.IndicarSueldoMaximo);
            Empleado._delSueldo -= new DelSueldo(Empleados.GuardarLog);
            switch (this.cmbTipo.SelectedIndex)
            {
                case 0:
                    Empleado._delSueldo += new DelSueldo(Empleados.IndicarSueldoMaximo);
                    break;
                case 1:
                    Empleado._delSueldo += new DelSueldo(Empleados.GuardarLog);
                    break;
                case 2:
                    Empleado._delSueldo += new DelSueldo(Empleados.IndicarSueldoMaximo);
                    Empleado._delSueldo += new DelSueldo(Empleados.GuardarLog);
                    break;
                default:
                    break;
            }
        }
        public static void IndicarSueldoMaximo(EmpleadoMejorado empleado, EmpleadoSueldoArgs sueldo)
        {
            MessageBox.Show(empleado.Nombre + " - " + empleado.Legajo.ToString() + " Se le queria asignar  " + sueldo.Sueldo.ToString());
        }
        public static void GuardarLog(EmpleadoMejorado empleado, EmpleadoSueldoArgs sueldo)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter("incidentes.log", true))
                {

                    writer.WriteLine(DateTime.Now.ToShortDateString() + " a las " + DateTime.Now.ToString("H:mm") + " " +
                            empleado.Nombre + " | " + empleado.Legajo + " sueldo que se queria asginar " + sueldo.Sueldo);
                }

            }
            catch
            {
                Console.WriteLine("Error al intentar guardar el incidente");
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            float sueldo;
            int legajo;
            float.TryParse(this.txtSueldo.Text, out sueldo);
            int.TryParse(this.txtLegajo.Text, out legajo);
            this.Empleado.Nombre = this.txtNombre.Text;
            this.Empleado.Legajo = legajo;
            this.Empleado.Sueldo = sueldo;
        }
    }
}
