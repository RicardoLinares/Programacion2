using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase22.Entidades;
namespace Clase22.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Program programa = new Program();
            empleado._limiteSueldo += new DelegadoSueldo(Program.LimiteSueldoEmpleado);
            empleado._limiteSueldo += new DelegadoSueldo(programa.GuardarLog);
            empleado.Nombre = "Tomas";
            empleado.Legajo = 202;
            empleado.Sueldo = 230000;
            Empleado empleado2 = new Empleado();
            Console.WriteLine(empleado.ToString());
            Console.ReadLine();




        }

        private static void LimiteSueldoEmpleado(Empleado empleado, float sueldo)
        {
            Console.WriteLine(empleado.Nombre + " - " + empleado.Legajo.ToString() + " Se le queria asignar  " + sueldo.ToString());
        }

        public void GuardarLog(Empleado empleado, float sueldo)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter("incidentes.log", true))
                {

                    writer.WriteLine(DateTime.Now.ToShortDateString() + " a las " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + " " +
                            empleado.Nombre + " | " + empleado.Legajo + " sueldo que se queria asginar " + sueldo);
                }

            }
            catch
            {
                Console.WriteLine("Error al intentar guardar el incidente");
            }
        }
    }
}
