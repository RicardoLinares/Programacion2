using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Title = "Ejercicio 2";
            Console.Write("Ingrese un Numero: ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch
            {

            }
            finally
            {

            }

            do
            {

                if(numero > 0)
                {
                    Console.WriteLine("El cuadrado de {0} es {1}", numero, Math.Pow(numero, 2));

                    Console.WriteLine("El cubo de {0} es {1}", numero ,Math.Pow(numero, 3));
                    break;
                }
                else
                {
                    Ejercicio_02.ErrorMessages("ERROR. ¡Reingresar número!");
                    Console.Write("Ingrese un Numero: ");
                try
                    {
                        numero = int.Parse(Console.ReadLine());
                    }
                catch
                    {
                        continue;
                    }
                finally
                    { 

                    }
                }

            } while (true);
            Console.ReadLine();
        }

        public static void ErrorMessages(string objetivo)
        {
            ConsoleColor colorBase = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(objetivo);
            Console.ForegroundColor = colorBase;
            return;
        }
    }
}
