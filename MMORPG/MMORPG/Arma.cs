using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Arma : Item
    {
        private int danioBase;

        public Arma(string nombreItem, int danioBase)
           : base(nombreItem)
        {
            this.danioBase = danioBase;
        }
    }
}
