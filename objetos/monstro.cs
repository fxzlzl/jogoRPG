using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class monstro : criaturaViva
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DanoMax { get; set; }
        public int ExpRecompensa { get; set; }
        public int OuroRecompensa { get; set; }
    }
}
