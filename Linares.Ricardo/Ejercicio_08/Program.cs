using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        { 
            Console.Title = "Ejercicio 8";
            float valorHoras;
            string nombre;
            string listadoDeEmpleados = "";
            int antiguedad;
            int horasTrabajadasMensuales;
            int cantDeEmpleadosIngresados = 1;

            float salarioBruto;
            float salarioTotal;
            float descuentos;

            do
            {
                Console.WriteLine("Calcular Salario Mensual: ");
                Console.Write("Ingrese el nombre del empleado n°{0}", cantDeEmpleadosIngresados);
                nombre = Console.ReadLine();
                Console.Write("Ingrese el valor de las horas del empleado n°{0}", cantDeEmpleadosIngresados);
                valorHoras = int.Parse(Console.ReadLine());
                Console.Write("Ingrese los años de antiguedad del empleado n°{0}", cantDeEmpleadosIngresados);
                antiguedad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas este mes por el empleado n°{0}", cantDeEmpleadosIngresados);
                horasTrabajadasMensuales = int.Parse(Console.ReadLine());
                
            } while (true);
        }

        static float CalcularSalarioBruto(float valoHoras, int cantDeHorasTrabajadas, int antiguedad)
        {
            float total = 0;
            total = valoHoras * cantDeHorasTrabajadas;
            total += antiguedad * 150;
            return total;
        }
        static float CalcularSalarioTotal(float salarioBruto, out float descuento)
        {
            float total = 0;
            descuento = salarioBruto % 13;
            total = salarioBruto - descuento;
            return total;
        }
    }
}
