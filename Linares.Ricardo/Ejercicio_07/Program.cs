using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            DateTime persona = new DateTime();
            int aux;
            int diasDelMes;

            do
            {
                Console.WriteLine("Ingrese el dia de nacimiento(1900 - 2018):");
                aux = int.Parse(Console.ReadLine());
            }
            while (aux <= 1900 || aux > 2018);
            persona = persona.AddYears(aux - 1);
            do
            {
                Console.WriteLine("Ingrese el dia de nacimiento(1 - 12):");
                aux = int.Parse(Console.ReadLine());
            }
            while (aux <= 0 || aux > 12);
            persona = persona.AddMonths(aux - 1);

            diasDelMes = CalcularDiasDelMes(persona);
            do
            {
                Console.WriteLine("Ingrese el dia de nacimiento(1 - {0}):", diasDelMes);
                aux = int.Parse(Console.ReadLine());
            }
            while (aux <= 0 || aux > diasDelMes);
            persona = persona.AddDays(aux - 1);


            Console.WriteLine("Usted nacio el dia {0:dddd dd}  de {0:MMMMM} del año {0:yyyy} y vivio {1} dias", persona, CalcularDiasVividos(persona));
            Console.ReadLine();
        }
        public static int CalcularDiasDelMes(DateTime mes)
        {
            int respuesta = 0;
            DateTime aux = new DateTime();
            aux = aux.AddYears(mes.Year - 1);
            aux = aux.AddMonths(mes.Month - 1);
            do
            {
                respuesta++;
                aux = aux.AddDays(1);
            } while (mes.Month == aux.Month);
            return respuesta;
        }
        public static int CalcularDiasVividos(DateTime persona)
        {
            DateTime ahora = DateTime.Now;
            DateTime aux = persona;
            int dias = 0;

            do
            {
                dias++;
                aux = aux.AddDays(1);
            } while (aux.Day != ahora.Day || aux.Month != ahora.Month || aux.Year != ahora.Year);

            return dias;
        }
    }
}
