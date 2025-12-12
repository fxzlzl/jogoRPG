using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class healingPot : item
    {
        public int QtdCura { get; private set; }

        public healingPot(int id, string nome, string nomePlural, int qtdCura)
            : base(id, nome, nomePlural)
        {
            QtdCura = qtdCura;
        }
    }
}
