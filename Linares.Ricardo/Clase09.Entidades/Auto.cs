using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {
        protected int _cantAsientos;

        public Auto(int cantidadAsientos, String patente, EMarca marca, Byte ruedas) : base(patente, ruedas, marca)
        {
            this._cantAsientos = cantidadAsientos;
        }
        public string MostrarAuto()
        {
            return base.Mostrar() + "Cantidad de Asientos: " + this._cantAsientos.ToString();
        }

    }
}
