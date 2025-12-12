using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class item
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string NomePlural { get; private set; }

        public item(int id, string nome, string nomePlural)
        {
            ID = id;
            Nome = nome;
            NomePlural = nomePlural; 
        }
    }
}
