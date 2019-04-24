using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgSystem
{
    public class Battler
    {
        private Stats _charStats;
        private string _name;
        private int _damange;

        public Battler()
        {
            this._charStats = new Stats();
        }
    }
}
