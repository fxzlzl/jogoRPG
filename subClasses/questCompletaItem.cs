using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class questCompletaItem
    {
        public item Detalhes { get; set; }
        public int Quantidade { get; set; }
        public questCompletaItem(item detalhes, int quantidade)
        {
            Detalhes = detalhes;
            Quantidade = quantidade;
        }
    }
}
