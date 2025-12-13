using System.Collections.Generic;

namespace jogoRPG
{
    public class monstro : criaturaViva
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int MaxDMG { get; private set; }
        public int recEXP { get; private set; }
        public int recOuro { get; private set; }
        public List<itemLooteado> tabelaLoot { get; set; }

        public monstro( int id, string nome, int danoMax, int recXP, int recOro, int hpAtual, int hpMax )
            : base(hpAtual, hpMax)
        {

            ID = id;
            Name = nome;
            MaxDMG = danoMax;
            recEXP = recXP;
            recOuro = recOro;

            tabelaLoot = new List<itemLooteado>();
        }
    }
}
