using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class criaturaViva
    {
        public int hpAtual { get; private set; }
        public int hpMax { get; private set; }

        public criaturaViva(int HPatual, int HPmax)
        {
            hpAtual = HPatual;
            hpMax = HPmax;
        }
    }
}
