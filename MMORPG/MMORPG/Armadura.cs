using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Armadura : Item
    {
        private int cantDefensa;


        public Armadura(string nombreItem, int cantDefensa)
            :base(nombreItem)
        {
            this.cantDefensa = cantDefensa;
        }






    }
}
