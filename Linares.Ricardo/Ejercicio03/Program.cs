using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            int numero;
            Console.Write("Ingrese un Numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= numero; i++)
            {
                if(i % 2 == 1 || i == 2)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}
