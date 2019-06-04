using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16.Entidades
{
    public class DepositoDeCocinas
    {
        private int _cantDeCocinas;

        private List<Cocina> _lista;

        public DepositoDeCocinas(int cantidad)
        {
            this._cantDeCocinas = cantidad;
            this._lista = new List<Cocina>(cantidad);
        }

        public bool Agregar(Cocina cocina)
        {
            return this + cocina;
        }

        public bool Remover(Cocina cocina)
        {
            return this - cocina;
        }

        public static bool operator ==(DepositoDeCocinas deposito, Cocina cocina)
        {
            bool respuesta = false;
            foreach (Cocina b in deposito._lista)
            {
                if (cocina.Equals(b))
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
        public static bool operator !=(DepositoDeCocinas deposito, Cocina cocina)
        {
            return !(deposito == cocina);
        }
        public static bool operator +(DepositoDeCocinas deposito, Cocina cocina)
        {
            bool respuesta = false;
            if (deposito._cantDeCocinas > deposito._lista.Count)
            {
                deposito._lista.Add(cocina);
                respuesta = true;
            }
            return respuesta;
        }
        public static bool operator -(DepositoDeCocinas deposito, Cocina cocina)
        {
            bool respuesta = false;
            int indice = deposito.GetIndice(cocina);
            if (indice != -1)
            {
                deposito._lista.RemoveAt(indice);
                respuesta = true;
            }
            return respuesta;
        }
        private int GetIndice(Cocina cocina)
        {
            return this._lista.IndexOf(cocina);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Deposito de cocinas de {0} Capacidad\n", this._cantDeCocinas);
            sb.AppendLine("Cocinas del deposito : ");
            foreach (Cocina cocina in this._lista)
            {
                sb.AppendFormat("{0}", cocina.ToString());
                sb.AppendLine("\n");
            }

            return sb.ToString();
        }
    }
}
