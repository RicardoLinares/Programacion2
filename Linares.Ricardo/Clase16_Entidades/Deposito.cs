using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
    public class Deposito<T>
    {
        private int _cantidad;

        private List<T> _lista;

        public Deposito(int cantidad)
        {
            this._cantidad = cantidad;
            this._lista = new List<T>(cantidad);
        }

        public bool Agregar(T a)
        {
            return this + a;
        }

        public bool Remover(T a)
        {
            return this - a;
        }

        public static bool operator ==(Deposito<T> deposito, T a)
        {
            bool respuesta = false;
            foreach(T b in deposito._lista)
            {
                if(a.Equals(b))
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(Deposito<T> deposito, T a)
        {
            return !(deposito == a);
        }
        public static bool operator +(Deposito<T> deposito, T a)
        {
            bool respuesta = false;
            if (deposito._cantidad > deposito._lista.Count)
            {
                deposito._lista.Add(a);
                respuesta = true;
            }
            return respuesta;
        }
        public static bool operator -(Deposito<T> deposito, T a)
        {
            bool respuesta = false;
            int indice = deposito.GetIndice(a);
            if (indice != -1)
            {
                deposito._lista.RemoveAt(indice);
                respuesta = true;
            }
            return respuesta;
        }
        private int GetIndice(T a)
        {
            return this._lista.IndexOf(a);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Deposito de {0} con {1} de Capacidad\n",typeof(T).Name, this._cantidad);
            foreach (T T in this._lista)
            {
                sb.AppendFormat("{0}", T.ToString());
                sb.AppendLine("\n");
            }

            return sb.ToString();
        }
    }
}
