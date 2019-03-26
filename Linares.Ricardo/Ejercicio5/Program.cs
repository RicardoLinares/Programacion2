using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Title = "Ejercicio 5";
            Console.WriteLine("Este programa va a buscar numeros centricos hasta el ingresado\nIngrese un Numero:");
            numero = int.Parse(Console.ReadLine());
            for(int i = 1; i <= numero; i++)
            {
                if(CentroNumerico(i))
                {
                    Console.WriteLine("{0} es un numero centrico", i);
                }
            }
            Console.ReadLine();
        }

        // calcula cual es el centro numerico 
        static bool CentroNumerico(int numeroPedido)
        {
            bool respuesta = false;
            int acumAnteriores = 0;
            int acumDespues = 0;
            for (int i = numeroPedido - 1; i > 0; i--)
            {
                acumAnteriores += i;
            }
            for (int i = numeroPedido + 1; ; i++)
            {
                acumDespues += i;
                if(acumDespues == acumAnteriores)
                {
                    respuesta = true;
                    break;
                }
                else if (acumAnteriores < acumDespues)
                {
                    break;
                }
            }

            return respuesta;
        }
    }
}
