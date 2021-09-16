using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG
{
    class Hacha : Arma
    {
        private float porcentajeMin = 0;
        private float porcentajeMax = 100;
        private int AumentoPorCritico = 2;


        public Hacha(string nombreItem, int danioBase)
         : base(nombreItem, danioBase)
        {
        }

        public Boolean golpeCritico()
        {
            return true;
        }
    }

}
