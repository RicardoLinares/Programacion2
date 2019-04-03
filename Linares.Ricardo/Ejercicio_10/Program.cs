using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int numero;
            Console.WriteLine("Este programa crea una piramide con altura dada:\ningrese un numero:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(ConstruirEscalonPiramide(i));
                if (i == 40)
                {
                    Console.WriteLine("no se puede continuar la piramide:");
                    break;
                }
            }
            Console.ReadLine();
        }
        static string ConstruirEscalonPiramide(int tamanio)
        {

            string respuesta = "";

            if (tamanio > 0)
            {
                for(int i = 0; i< 40 - tamanio; i++)
                {
                    respuesta += " ";
                }
                respuesta += "*";
                for (int i = 1; i < tamanio; i++)
                {
                    respuesta += "**";
                }
            }

            return respuesta;
        }
    }
}
