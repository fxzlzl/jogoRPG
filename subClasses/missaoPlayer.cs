using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
public class missaoPlayer
    {
        public quest Detalhes;
        public bool concluida;

        public missaoPlayer(quest detalhes)
        {
            Detalhes = detalhes;
            concluida = false;
        }
    }
}
