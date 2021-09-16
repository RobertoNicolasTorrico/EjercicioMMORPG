using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Arco : Arma 
    {
        private Flecha flecha;

        public Arco(string nombreItem, int danioBase)
        : base(nombreItem, danioBase)
        {
        }

    }
}
