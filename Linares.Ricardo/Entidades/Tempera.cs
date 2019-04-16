using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tempera
    {
        private string _marca;

        private ConsoleColor _color;

        private int _cantidad;

        public string MiMarca
        {
            get
            {
                return _marca;
            }
        }

        public ConsoleColor MiColor
        {
            get
            {
                return _color;
            }
        }

        /// <summary>
        /// get: returns _cantidad
        /// set: agrega el valor recibido a cantidad;
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                if (this._cantidad + value <= 100 && this._cantidad + value >= 0)
                {
                    this._cantidad += value;
                }
            }
        }


        public Tempera() : this("Desconocida", ConsoleColor.Black, 0)
        {

        }
        public Tempera(string marca) : this(marca, ConsoleColor.Black, 0)
        {

        }
        public Tempera(string marca, ConsoleColor color) : this(marca, color, 0)
        {

        }
        public Tempera(string marca, ConsoleColor color, int cantidad)
        {
            this._marca = marca;
            this._color = color;
            this.Cantidad = cantidad;
        }

        public string Mostrar()
        {
            return this._marca + " / " + this._color.ToString() + " / " + this._cantidad.ToString();
        }


        public static bool operator ==(Tempera temperaA, Tempera temperaB)
        {
            bool resultado = false;
            if(temperaA._color == temperaB._color)
            {
                if(temperaA._marca == temperaB._marca)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        public static bool operator !=(Tempera temperaA, Tempera temperaB)
        {
            return !(temperaA == temperaB);
        }
        public static Tempera operator +(Tempera objetivo, Tempera agregado)
        {
            if(objetivo != null && agregado != null)
            {
                if (objetivo == agregado)
                {
                    objetivo.Cantidad = agregado.Cantidad;
                }
            }
            return objetivo;
        }
    }
}
