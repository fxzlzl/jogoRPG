using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class local
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public item ItemNecessario { get; set; }
        public quest MissaoDisponivel { get; set; }
        public monstro MonstrosAqui { get; set; }
        public local localNorte { get; set; }
        public local localLeste { get; set; }
        public local localSul { get; set; }
        public local localOeste { get; set; }

        public local( int id, string nome, string descricao, item itemNecessario = null,
            quest missaoDisponivel = null, monstro monstrosAqui = null )
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            ItemNecessario = itemNecessario;
            MissaoDisponivel = missaoDisponivel;
            MonstrosAqui = monstrosAqui;
        }
    }
}
