using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem
{
    public class Stats
    {
        private int _fuerza;
        private int _vida;
        private int _nivel;
        private int _exp;

        public int Nivel
        {
            get
            {
                return this._nivel;
            }
            set
            {
                if(value > 0 || value <= 100)
                {
                    this._nivel = value;
                }
                else
                {
                    this._nivel = 1;
                }
            }
        }
        public int Fuerza
        {
            get
            {
                return this._fuerza;
            }
            set
            {
                if (value > 0)
                {
                    this._fuerza = value;
                }
                else
                {
                    this._fuerza = 1;
                }
            }
        }
        public int Vida
        {
            get
            {
                return this._vida;
            }
            set
            {
                if (!(value <= 0))
                    this._vida = value;
            }
        }
        public int Experience
        {
            get
            {
                return this._exp;
            }
            set
            {
                if(value > 0)
                {
                    CalcularLvLUp(value);
                }
            }
        }
        public Stats() : this(1,1,1)
        {

        }
        public Stats(int fuerza, int vida, int nivel)
        {
            this._fuerza = fuerza;
            this._vida = vida;
            this.Nivel = nivel;
        }
        
        private bool CalcularLvLUp(int exp)
        {
            bool respuesta = false;
            this._exp += exp;
            if(this.Nivel * 30 < exp)
            {
                this.Nivel += 1;
            }
            return respuesta;
        }
    }
}
