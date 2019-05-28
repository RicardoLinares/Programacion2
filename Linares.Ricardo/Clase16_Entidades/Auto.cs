using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get
            {
                return this._color;
            }
        }

        public string Marca
        {
            get
            {
                return this._marca;
            }
        }

        public Auto(string marca, string color)
        {
            this._marca = marca;
            this._color = color;
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Auto)
            {
                respuesta = this == (Auto)obj;
            }
            return respuesta;
        }
        public override string ToString()
        {
            return "Marca: " + this.Marca + "- Color: " + this.Color;
        }
        public static bool operator ==(Auto a, Auto b)
        {
            bool respuesta = false;
            if(a.Color == b.Color)
            {
                if(a.Marca == a.Marca)
                {
                    respuesta = true;
                }
            }
            return respuesta;  
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
    }
}
