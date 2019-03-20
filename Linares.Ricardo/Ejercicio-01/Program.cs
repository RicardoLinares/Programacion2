using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo;
            int maximo;
            float acumulador = 0;
            int contador = 0;
            float promedio;

            Console.Title = "Ejercicio 1";

            Console.WriteLine("Ingrese 5 Numeros: ");
            numero = int.Parse(Console.ReadLine());

            minimo = numero;
            maximo = numero;
            acumulador += numero;
            contador++;

            for (int i = 0; i < 4; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (minimo > numero)
                    minimo = numero;
                else if (maximo < numero)
                    maximo = numero;
                acumulador += numero;
                contador++;
            }

            promedio = acumulador / contador;
            Console.WriteLine(" Valor Maximo = {0}\n Valor Minimo = {1}\n Promedio = {2}", maximo, minimo, promedio);

            Console.ReadLine();
        }
    }
}
