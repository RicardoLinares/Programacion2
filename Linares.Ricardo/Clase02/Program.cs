using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "VENDIDO";
            Sello.color = ConsoleColor.Red;

            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();

            Sello.ImprimirEnColor();
            Console.ReadLine();
            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());
            Console.ReadLine();

        }
    }
}
