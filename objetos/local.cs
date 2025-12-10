using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class local
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public local(int id, string nome, string descricao)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
