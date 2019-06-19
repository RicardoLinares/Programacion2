using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22.Entidades
{
    public class EmpleadoMejorado
    {
        public DelSueldo _delSueldo;
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public float Sueldo
        {
            get
            {
                return this._sueldo;
            }
            set
            {
                if (value > 12000)
                {

                    EmpleadoSueldoArgs args = new EmpleadoSueldoArgs();
                    args.Sueldo = value;
                    this._delSueldo(this, args);
                }
                else
                {
                    this._sueldo = value;
                }
            }
        }


        public override string ToString()
        {
            return this._nombre + " | " + this._legajo.ToString() + " | " + this._sueldo.ToString();
        }
    }
}
