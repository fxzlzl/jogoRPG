using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class arma : item
    {
        public int DanoMIN { get; private set; }
        public int DanoMAX { get; private set; }

        public arma( int id, string nome, string nomePlural, int danoMin, int danoMax )
            : base(id, nome, nomePlural)
        {
            DanoMAX = danoMax;
            DanoMIN = danoMin;
        }
    }
}
