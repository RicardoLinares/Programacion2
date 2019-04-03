using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma() : this("Sin Marca", null,0)
        {
        }

        public Pluma(string marca) : this(marca,null,0)
        {
        }
        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {

        }
        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }


        private string Mostrar()
        {
            return this._marca + ", Tinta:" + Tinta.Mostrar(this._tinta) + ", " + this._cantidad;
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma._tinta == tinta;
            //bool respuesta = false; ERROR: YA ESTABA HACIENDO UNA COMPARACION DE TRUE O FALSE
            //if(pluma._tinta == tinta)
            //{
            //    respuesta = true;
            //}
            //return respuesta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        // sobrecarga de asignacion
        public static explicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma == tinta)
            {
                if (pluma._cantidad + 10 < 100)
                    pluma._cantidad += 10;
            }
            return pluma;
        }
    }
}
