using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;
namespace Clase05.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta porDefecto = new Tinta();
            Tinta porParametros = new Tinta(ConsoleColor.Red);
            Tinta porCompleto = new Tinta(ConsoleColor.Yellow, ETipoTinta.China);
            Tinta tinta = new Tinta();

            Pluma plumita = new Pluma("bic", porCompleto, 20);
            plumita += porCompleto;
            string textito = (string)plumita;



            if (porDefecto != tinta)
            {
                Console.WriteLine("NO SON IGUALES");
            }
            else
            {
                Console.WriteLine("SON IGUALES");
            }
            Console.WriteLine("{0}, por defecto\n{1}, Parmetro color\n{2}, con 2 parametros\n{3}, la pluma",
                Tinta.Mostrar(porDefecto),
                Tinta.Mostrar(porParametros),
                Tinta.Mostrar(porCompleto),
                textito);
            Console.ReadLine();
        }
    }
}
