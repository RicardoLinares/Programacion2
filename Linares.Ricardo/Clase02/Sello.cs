using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            string mensaje = ArmarFormatoMensaje();
            return mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = " ";
        }

        public static void ImprimirEnColor()
        {

            ConsoleColor colorOriginal  = Console.ForegroundColor;
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = colorOriginal;
        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeAcabado = "";
            string cobertura = "";
            int cantidadDeCarateres;

            cantidadDeCarateres = Sello.mensaje.Length;

            for (int i = 0;i < 2 + cantidadDeCarateres;i++)
            {
                cobertura += "*";
            }

            mensajeAcabado += cobertura;
            mensajeAcabado += "\n";
            mensajeAcabado += "*" + Sello.mensaje + "*";
            mensajeAcabado += "\n";
            mensajeAcabado += cobertura;

            return mensajeAcabado;
        }
    }
}
