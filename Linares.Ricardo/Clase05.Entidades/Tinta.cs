using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta() : this(ConsoleColor.Black,ETipoTinta.Comun)
        {
        }

        public Tinta(ConsoleColor color) : this(color,ETipoTinta.Comun)
        {
        }
        public Tinta(ConsoleColor color,  ETipoTinta tipo)
        {
            this._tipoTinta = tipo;
            this._color = color;
        }
        
        private string Mostrar()
        {
            string valores = "";
            valores += this._color.ToString() +", "+ this._tipoTinta.ToString();
            return valores;
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        //sobrecarga de operadores // palabra revervada operator
        public static bool operator ==(Tinta tintaA, Tinta tintaB)
        {
            bool respuesta = false;
            if (tintaA._color == tintaB._color)
            {
                if (tintaA._tipoTinta == tintaB._tipoTinta)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Tinta tintaA, Tinta tintaB)
        {
            return !(tintaA == tintaB);
        }
    }
}
