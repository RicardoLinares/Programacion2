using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// CLase 9 - herencia
/// </summary>
namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        public Camion(float tara, String patente, EMarca marca, Byte ruedas) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }
        public override double Precio
        {
            get;
            set;
        }
        public override double CalcularPrecioConIva()
        {
            return this.Precio * 1.21;
        }
        protected override string Mostrar()
        {
            return base.Mostrar() + "Tara del camion: " + this._tara.ToString();
        }
        public override string ToString()
        {
            return Mostrar();
        }
    }
}
