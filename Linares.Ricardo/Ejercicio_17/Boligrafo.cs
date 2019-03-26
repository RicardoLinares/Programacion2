using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        public const short cantidadDeTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }
        public void Recargar()
        {
            this.SetTinta(Boligrafo.cantidadDeTintaMaxima);
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            bool sePudoPintar = false;
            dibujo = "";
            if(this.GetTinta() > 0)
            {
                sePudoPintar = true;
                for(int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                    this.SetTinta(-1);
                    if (this.GetTinta() == 0)
                    {
                        break;
                    }
                }
            }
            return sePudoPintar;
        }
        private void SetTinta(short tinta)
        {
            if(this.tinta + tinta <= cantidadDeTintaMaxima && this.tinta + tinta >= 0)
            {
                this.tinta += tinta;
            }
        }

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
    }
}
