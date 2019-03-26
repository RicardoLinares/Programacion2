using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string output;
            Boligrafo Rojo = new Boligrafo(ConsoleColor.Red, 50);
            Boligrafo Azul = new Boligrafo(ConsoleColor.Blue, 100);

            Console.ForegroundColor = Rojo.GetColor();
            Rojo.Pintar(10, out output);
            Console.WriteLine(output);
            Console.ReadLine();

            Console.ForegroundColor = Azul.GetColor();
            Azul.Pintar(10, out output);
            Console.WriteLine(output);
            Console.ReadLine();

            Console.ForegroundColor = Rojo.GetColor();
            Rojo.Pintar(50, out output);
            Console.WriteLine(output);
            Console.ReadLine();

            Console.ForegroundColor = Azul.GetColor();
            Azul.Pintar(50, out output);
            Console.WriteLine(output);
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Rojo.Recargar();
            Console.WriteLine("Recargando boligrafo rojo");
            Console.ReadLine();

            Console.ForegroundColor = Rojo.GetColor();
            Rojo.Pintar(100, out output);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
