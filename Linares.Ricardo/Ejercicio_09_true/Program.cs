using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09_true
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
 
            Console.Title = "Ejercicio 9";
            int numero;
            Console.WriteLine("Este programa crea una piramide con altura dada:\ningrese un numero:");
            numero = int.Parse(Console.ReadLine());

            for(int i = 1; i < numero; i++)
            {
                Console.WriteLine(ConstruirEscalonPiramide(i));
                if(i == 41)
                {
                    Console.WriteLine("no se puede continuar la piramid:");
                    break;
                }
            }
            Console.ReadLine();

        }

        static string ConstruirEscalonPiramide(int tamanio)
        {

            string respuesta = "";

            if(tamanio>0)
            {
                respuesta += "*";
                for(int i = 1; i < tamanio; i++)
                {
                    respuesta += "**";
                }
            }

            return respuesta;
        }
    }
}
