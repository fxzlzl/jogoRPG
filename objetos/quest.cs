using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class quest
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int RecompensaOuro { get; private set; }
        public int RecompensaXP { get; private set; }
        public item recompensaItem { get; private set; }
        public List <questCompletaItem> questCompletaItem { get; private set; }

        public quest(int id, string nome, string descricao, int recompensaXP, int recompensaOuro)
        {
            // Inicializa as props 
            ID = id;
            Nome = nome;
            Descricao = descricao;
            RecompensaOuro = recompensaOuro;
            RecompensaXP = recompensaXP;

            // Inicializa a lista de itens necessários  
            questCompletaItem = new List<questCompletaItem>();
        }
    }
}

