using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIdustrial;
        private double _precio;

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }

        public bool EsIndustrial
        {
            get
            {
                return this._esIdustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }

        public Cocina(int coidgo, double precio, bool esIndustrial)
        {
            this._codigo = coidgo;
            this._esIdustrial = esIndustrial;
            this._precio = precio;

        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool respuesta = false;
            if(a.Codigo == b.Codigo)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator!=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Cocina)
            {
                respuesta = this == (Cocina)obj;
            }
            return respuesta;
        }

        public override string ToString()
        {
            return "Codigo: " + this.Codigo + " - Es Industrial?: " + this.EsIndustrial + " - Precio: " + this.Precio;
        }
    }
}
