using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            int numerosEncontrados = 0;

            Console.Title = "Ejercicio 4";
            for (int i = 1; numerosEncontrados < 4; i++)
            {
                if(NumeroPerfecto(i))
                {
                    Console.WriteLine("{0} es un numero perfecto", i);
                    numerosEncontrados++;
                }
            }
            Console.ReadLine();
        }
        // devuelve si el numero es perfecto(true) o no(false)
        static public bool NumeroPerfecto(int numero)
        {
            bool respuesta = false;
            int acomulador = 0;

            for(int i = numero - 1; i > 0; i--)
            {
                if(numero%i == 0)
                {
                    acomulador += i;
                }
            }

            if(acomulador == numero)
            {
                respuesta = true;
            }


            return respuesta;
        }
    }
}
