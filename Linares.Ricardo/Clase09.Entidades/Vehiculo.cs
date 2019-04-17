using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Vehiculo
    {
        protected string _patente;
        protected EMarca _marca;
        protected Byte _cantRuedas;

        public string Patente
        {
            get
            {
                return _patente;
            }
        }

        public EMarca Marca
        {
            get
            {
                return _marca;
            }
        }

        public Vehiculo(string patente, Byte ruedas, EMarca marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }

        protected string Mostrar()
        {
            return "Patente: " + this._patente + "\nMarca: " + this._patente.ToString() + "\nCantidad de ruedas: " + this._cantRuedas.ToString() + "\n"; 
        }

        public static bool operator ==(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            bool respuesta = false;
            if(vehiculoA.Patente != null && vehiculoB.Patente != null)
            {
                if(vehiculoA.Patente == vehiculoB.Patente && vehiculoA.Marca == vehiculoB.Marca)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public static bool operator !=(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            return !(vehiculoA == vehiculoB);
        }
    }
}
