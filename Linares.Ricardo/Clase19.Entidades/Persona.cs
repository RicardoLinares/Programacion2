using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19.Entidades
{
    public class Persona
    {
        public int _id;
        public string _nombre;
        public string _apellido;
        public int _edad;

        public Persona(int id, string nombre, string apellido, int edad)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} | {1} | {2} | {3}", this._id, this._nombre, this._apellido, this._edad);
            return builder.ToString();
        }
    }
}
