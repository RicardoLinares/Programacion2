using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        public Moto(float cilindrada, String patente, EMarca marca, Byte ruedas) : base(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            return base.Mostrar() + "Cilindrado: " + this._cilindrada.ToString();
        }
    }
}
