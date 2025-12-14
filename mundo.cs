using jogoRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public static class mundo
    {
        public static readonly List<item> Items = new List<item>();
        public static readonly List<monstros> monstross = new List<monstros>();
        public static readonly List<quest> Quests = new List<quest>();
        public static readonly List<local> Locais = new List<local>();

        //items/armas/poções
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_rato_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_cobra_FANG = 4;
        public const int ITEM_ID_cobraSKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        //monstros
        public const int monstros_ID_rato = 1;
        public const int monstros_ID_cobra = 2;
        public const int monstros_ID_gigante_SPIDER = 3;

        //quests e seus IDs
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        //locais e seus IDs
        public const int local_ID_HOME = 1;
        public const int local_ID_TOWN_SQUARE = 2;
        public const int local_ID_GUARD_POST = 3;
        public const int local_ID_ALCHEMIST_HUT = 4;
        public const int local_ID_ALCHEMISTS_GARDEN = 5;
        public const int local_ID_FARMHOUSE = 6;
        public const int local_ID_FARM_FIELD = 7;
        public const int local_ID_BRIDGE = 8;
        public const int local_ID_SPIDER_FIELD = 9;

        static mundo()
        {
            PopulateItems();
            Populatemonstross();
            PopulateQuests();
            Populatelocals();
        }

        private static void PopulateItems()
        {
            Items.Add(new arma(ITEM_ID_RUSTY_SWORD, "Espada maneira", "Espadas Maneiras", 0, 5));
            Items.Add(new item(ITEM_ID_rato_TAIL, "rabo de rato", "rabos de rato"));
            Items.Add(new item(ITEM_ID_PIECE_OF_FUR, "Pedaço de fur", "Pedaços de fur"));
            Items.Add(new item(ITEM_ID_cobra_FANG, "Presa de cobra", "Presas de cobra"));
            Items.Add(new item(ITEM_ID_cobraSKIN, "Pele de cobra", "Peles de cobra"));
            Items.Add(new arma(ITEM_ID_CLUB, "Club", "Clubs", 3, 10));
            Items.Add(new healingPot(ITEM_ID_HEALING_POTION, "Poção de cura", "Poções de cura", 5));
            Items.Add(new item(ITEM_ID_SPIDER_FANG, "Presa de aranha", "Presas de aranha"));
            Items.Add(new item(ITEM_ID_SPIDER_SILK, "Seda de aranha", "Sedas de aranha"));
            Items.Add(new item(ITEM_ID_ADVENTURER_PASS, "Passe de aventureiro", "Passes de aventureiro"));
        }

        private static void Populatemonstross()
        {
            monstros rato = new monstros(monstros_ID_rato, "rato", 5, 3, 10, 3, 3);
            rato.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_rato_TAIL), 75, false));
            rato.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            monstros cobra = new monstros(monstros_ID_cobra, "cobra", 5, 3, 10, 3, 3);
            cobra.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_cobra_FANG), 75, false));
            cobra.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_cobraSKIN), 75, true));

            monstros giganteSpider = new monstros(monstros_ID_gigante_SPIDER, "aranha gigante", 20, 5, 40, 10, 10);
            giganteSpider.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giganteSpider.tabelaLoot.Add(new itemLooteado(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            monstross.Add(rato);
            monstross.Add(cobra);
            monstross.Add(giganteSpider);
        }

        private static void PopulateQuests()
        {
            quest clearAlchemistGarden =
                new quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Limpe o jardim do alquimista",
                    "Mate todos os ratos no jardim do alquimista e traa de volta 3 rabos de rato. Você recebera uma poçao de vida e 10 peças de ouro em troca.", 20, 10);

            clearAlchemistGarden.questCompletaItem.Add(new questCompletaItem(ItemByID(ITEM_ID_rato_TAIL), 3));

            clearAlchemistGarden.RecompensaItem = ItemByID(ITEM_ID_HEALING_POTION);

            quest clearFarmersField =
                new quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Limpe o campo dos fazendeiros",
                    "Mate as cobras nas plantações dos fazendeiros e traga de volta 3 presas de aranhas. Em troca você receberá um passe de aventureiro e algumas peças de ouro.", 20, 20);

            clearFarmersField.questCompletaItem.Add(new questCompletaItem(ItemByID(ITEM_ID_cobra_FANG), 3));

            clearFarmersField.RecompensaItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void Populatelocals()
        {
            // Create each local
            local home = new local(local_ID_HOME, "Home", "Sua Casa. Você realmente precisa dar um jeito nesse lugar.");

            local townSquare = new local(local_ID_TOWN_SQUARE, "Town square", "Você vê uma fonte.");

            local alchemistHut = new local(local_ID_ALCHEMIST_HUT, "Toca do alquimista", "Tem algumas plantas estranhas na frente do local.");
            alchemistHut.MissaoDisponivel = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            local alchemistsGarden = new local(local_ID_ALCHEMISTS_GARDEN, "Jardim do Alquimista", "Algumas plantas são feitas aqui.");
            alchemistsGarden.monstrosAqui = monstrosByID(monstros_ID_rato);

            local farmhouse = new local(local_ID_FARMHOUSE, "Fazenda", "Uma fazenda pequena, com um fazendeiro lá na frente.");
            farmhouse.MissaoDisponivel = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            local farmersField = new local(local_ID_FARM_FIELD, "Campo dos fazendeiros", "Você vê diversas plantações por aqui.");
            farmersField.monstrosAqui = monstrosByID(monstros_ID_cobra);

            local guardPost = new local(local_ID_GUARD_POST, "Posto de vigia", "Aqui é grande, o guarda deve estar olhando pra você.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            local bridge = new local(local_ID_BRIDGE, "Ponte", "Uma ponte de pedra que cruza um lago.");

            local spiderField = new local(local_ID_SPIDER_FIELD, "Floresta", "Você vê teias de aranhas cobrindo galhos e árvores, isso te assusta.");
            spiderField.monstrosAqui = monstrosByID(monstros_ID_gigante_SPIDER);

            // Link the locals together
            home.localNorte = townSquare;

            townSquare.localNorte = alchemistHut;
            townSquare.localSul = home;
            townSquare.localLeste = guardPost;
            townSquare.localOeste = farmhouse;

            farmhouse.localLeste = townSquare;
            farmhouse.localOeste = farmersField;

            farmersField.localLeste = farmhouse;

            alchemistHut.localSul = townSquare;
            alchemistHut.localNorte = alchemistsGarden;

            alchemistsGarden.localSul = alchemistHut;

            guardPost.localLeste = bridge;
            guardPost.localOeste = townSquare;

            bridge.localOeste = guardPost;
            bridge.localLeste = spiderField;

            spiderField.localOeste = bridge;

            // Add the locals to the static list
            Locais.Add(home);
            Locais.Add(townSquare);
            Locais.Add(guardPost);
            Locais.Add(alchemistHut);
            Locais.Add(alchemistsGarden);
            Locais.Add(farmhouse);
            Locais.Add(farmersField);
            Locais.Add(bridge);
            Locais.Add(spiderField);
        }

        public static item ItemByID( int id )
        {
            foreach (item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static monstros monstrosByID( int id )
        {
            foreach (monstros monstros in monstross)
            {
                if (monstros.ID == id)
                {
                    return monstros;
                }
            }

            return null;
        }

        public static quest QuestByID( int id )
        {
            foreach (quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static local localByID( int id )
        {
            foreach (local local in Locais)
            {
                if (local.ID == id)
                {
                    return local;
                }
            }

            return null;
        }
    }
}