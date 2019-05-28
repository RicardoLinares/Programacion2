using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
    public class DepositoDeAutos
    {
        private int _cantDeAutos;

        private List<Auto> _lista;

        public DepositoDeAutos(int cantidad)
        {
            this._cantDeAutos = cantidad;
            this._lista = new List<Auto>(cantidad);
        }

        public bool Agregar(Auto auto)
        {
            return this + auto;
        }

        public bool Remover(Auto auto)
        {
            return this - auto;
        }

        public static bool operator ==(DepositoDeAutos deposito, Auto auto)
        {
            bool respuesta = false;
            foreach (Auto b in deposito._lista)
            {
                if (a.Equals(b))
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(DepositoDeAutos deposito, Auto auto)
        {
            return !(deposito == auto);
        }
        public static bool operator +(DepositoDeAutos deposito, Auto auto)
        {
            bool respuesta = false;
            if(deposito._cantDeAutos > deposito._lista.Count)
            {
                deposito._lista.Add(auto);
                respuesta = true;
            }
            return respuesta;
        }
        public static bool operator -(DepositoDeAutos deposito, Auto auto)
        {
            bool respuesta = false;
            int indice = deposito.GetIndice(auto);
            if(indice != -1)
            {
                deposito._lista.RemoveAt(indice);
                respuesta = true;
            }
            return respuesta;
        }
        private int GetIndice(Auto auto)
        {
            return this._lista.IndexOf(auto);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Deposito de autos de {0} Capacidad\n", this._cantDeAutos);
            sb.AppendLine("Autos del deposito : ");
            foreach(Auto auto in this._lista)
            {
                sb.AppendFormat("{0}", auto.ToString());
                sb.AppendLine("\n");
            }

            return sb.ToString();
        }
    }
}
