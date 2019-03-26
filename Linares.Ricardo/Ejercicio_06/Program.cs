using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            int desdeAnio;
            int hastaAnio;

            Console.WriteLine("Este programa va a calcular todos los años bisiestos que se encuentre en un intervalo");
            Console.WriteLine("ingrese desde que año: ");
            desdeAnio = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese hasta que año: ");
            hastaAnio = int.Parse(Console.ReadLine());

            for(int i = desdeAnio; i < hastaAnio; i++)
            {
                if(CalcularBisiesto(i))
                {
                    if(i <= 0)
                    {
                        Console.WriteLine("{0} a.C es un año bisiesto", -1*(i - 1));
                    }
                    else
                    {
                        Console.WriteLine("{0} d.C es un año bisiesto", i);
                    }
                }
            }

            Console.ReadLine();
        }

        public static bool CalcularBisiesto(int anio)
        {
            bool respuesta = false;
            if(anio % 100 != 0)
            {
                if (anio % 4 == 0)
                {
                    respuesta = true;
                }
            }
            else if(anio % 400 == 0)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
