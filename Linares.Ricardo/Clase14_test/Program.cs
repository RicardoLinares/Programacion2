using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase14_Entidades;

namespace Clase14_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int resultado;
            numero = Console.ReadLine();
            if (ParseadoraDeEnteros.TryParse(numero, out resultado) )
            {
                Console.WriteLine(numero);
            }

            try
            {
                resultado = ParseadoraDeEnteros.Parse(numero);
            }
            catch (ErrorParserException e)
            {

                Console.WriteLine(e.Message + e.InnerException.Message);
            }
            Console.ReadLine();
        }
    }
}
