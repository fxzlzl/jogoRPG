using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class itemLooteado
    {
        public item detalhes {  get; set; }
        public int chanceDrop { get; set; }
        public bool itemPadrao { get; set; }
        public itemLooteado(item Detalhes, int ChanceDrop, bool ItemPadrao)
        {
            detalhes = Detalhes;
            chanceDrop = ChanceDrop;
            itemPadrao = ItemPadrao;
        }
    }
}
