using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paleta
    {
        public List<Tempera> _listTempera;
        private int _cantTempera;
        private int CantidadTempera
        {
            get
            {
                return _cantTempera;
            }
            set
            {
                if (value <= 0)
                {
                    value = 1;
                }
                _cantTempera = value;
            }
        }

        public Paleta() : this(5)
        {

        }
        public Paleta(int cantidad)
        {

            this.CantidadTempera = cantidad;
            this._listTempera = new List<Tempera>(this.CantidadTempera);
        }

        public static bool operator +(Paleta paleta, Tempera nuevaTempera)
        {
            bool sePuedeAgregar = true;
            foreach (Tempera tempera in paleta._listTempera)
            {
                if (tempera == nuevaTempera)
                {
                    sePuedeAgregar = false;
                }
            }
            if (sePuedeAgregar)
            {
                paleta._listTempera.Add(nuevaTempera);
            }
            return sePuedeAgregar;
        }
    }
}
