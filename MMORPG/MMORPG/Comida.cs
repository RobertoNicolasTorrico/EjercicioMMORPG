using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Comida : Item
    {
        private int cantVidaCura;
        private int cantSePuedeUsar;


        public Comida(string nombreItem, int cantVidaCura, int cantSePuedeUsar)
           : base(nombreItem)
        {
            this.cantVidaCura = cantVidaCura;
            this.cantSePuedeUsar = cantSePuedeUsar;
        }

    }
}
