using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04.Entidades;

namespace Clase_04_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cos = new Cosa();
            Cosa cos1 = new Cosa(50);
            Cosa cos2 = new Cosa(60, DateTime.MaxValue);
            Cosa cos3 = new Cosa(70, DateTime.MinValue, "aLgUiEn");

            Console.WriteLine(Cosa.Mostrar(cos));
            Console.WriteLine(cos1.Mostrar());
            Console.WriteLine(Cosa.Mostrar(cos2));
            Console.WriteLine(cos3.Mostrar());

            Console.ReadLine();

            cos.EstablecerValor(2);
            cos.EstablecerValor(DateTime.Now);
            cos.EstablecerValor("AAAAA");

            Console.WriteLine(Cosa.Mostrar(cos));

            Console.WriteLine(cos.Mostrar());
            Console.ReadLine();






        }
    }
}
