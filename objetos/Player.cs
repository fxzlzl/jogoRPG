using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class Player : criaturaViva
    {
        public int Ouro { get; private set; }
        public int xPontos { get; private set; }
        public int nivel { get; private set; }

        public Player(int hpAtual, int hpMax, int gold, int exPoints, int level)
            : base(hpAtual, hpMax)
        {
            Ouro = gold;
            xPontos = exPoints;
            nivel = level;
        }
    }
}
