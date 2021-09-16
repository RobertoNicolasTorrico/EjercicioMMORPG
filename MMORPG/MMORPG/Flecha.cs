using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Flecha : Item
    {
        private int danioflecha;
        private int cantStock;
        private int cantEquipada;
        public Flecha(string nombreItem, int danioflecha,int cantStock,int cantEquipada)
            : base(nombreItem)
        {
            this.danioflecha = danioflecha;
            this.cantStock = cantStock;
            this.cantEquipada = cantEquipada;
        }


    }
}
