using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    // las clases abstractas no tendran instancias de las mismas
    // se cosidera abstracta a una clase que es un concepto intangible o valga a redundancia abstracto
    // puede contener miembros abstractos. metodos y/o propiedades. solo tienen la firma, no la implementacion
    public abstract class Vehiculo
    {
        protected string _patente;
        protected EMarca _marca;
        protected Byte _cantRuedas;
        public abstract double Precio
        { get; set; }
        public abstract double CalcularPrecioConIva();
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

        protected virtual string Mostrar()
        {
            return "Patente: " + this._patente + "\nMarca: " + this._marca.ToString() + "\nCantidad de ruedas: " + this._cantRuedas.ToString() + "\n"; 
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

        public override bool Equals(object obj)
        {
            bool respuesta = false;
            if(obj is Vehiculo)
            {
                if((Vehiculo)obj == this)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
