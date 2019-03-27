using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Clase04.Entidades;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Cosa newCosa = new Cosa();
            newCosa.cadena = "ASD";
            Cosa newCosa2 = new Cosa();


            string name;
            Console.WriteLine(newCosa.Mostrar());
            Console.WriteLine(Cosa.Mostrar(newCosa2));
            Console.ReadKey();

            Console.Write("Ingrese su nombre : " + DateTime.Now);

            name = Console.ReadLine();

            Console.Write("Su nombre es ");
            WW3names(name);
            Console.ReadLine();

            Console.Write("Ingrese su apellido : ");

            name = name + " " + Console.ReadLine();

            Console.Write("Su nombre completo es ");
            WW3names(name);
            Console.ReadLine();
        }

        public static void WW3names(string objetivo)
        {
            ConsoleColor colorBase = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(objetivo);
            Console.ForegroundColor = colorBase;
            return;
        }
    }
}
