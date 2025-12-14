using jogoRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoRPG
{
    public class Player : criaturaViva
    {
        public int ouro { get; set; }
        public int EXP { get; set; }
        public int nivel { get; set; }
        public local localAtual { get; set; }
        public List<itemInventario> inventario { get; set; }
        public List<missaoPlayer> Missoes { get; set; }

        public Player( int currentHitPoints, int maximumHitPoints, int Ouro, int experiencePoints, int Nivel ) : base(currentHitPoints, maximumHitPoints)
        {
            ouro = Ouro;
            EXP = experiencePoints;
            nivel = Nivel;

            inventario = new List<itemInventario>();
            Missoes = new List<missaoPlayer>();
        }

        public bool HasRequiredItemToEnterThisLocation( local location )
        {
            if (location.ItemNecessario == null)
            {
                // There is no required item for this location, so return "true"
                return true;
            }

            // See if the player has the required item in their inventory
            foreach (itemInventario ii in inventario)
            {
                if (ii.Detalhes.ID == location.ItemNecessario.ID)
                {
                    // We found the required item, so return "true"
                    return true;
                }
            }

            // We didn't find the required item in their inventory, so return "false"
            return false;
        }

        public bool HasThisQuest( quest quest )
        {
            foreach (missaoPlayer playerQuest in Missoes)
            {
                if (playerQuest.Detalhes.ID == quest.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CompletedThisQuest( quest quest )
        {
            foreach (missaoPlayer playerQuest in Missoes)
            {
                if (playerQuest.Detalhes.ID == quest.ID)
                {
                    return playerQuest.concluida;
                }
            }

            return false;
        }

        public bool HasAllQuestCompletionItems( quest quest )
        {
            // See if the player has all the items needed to complete the quest here
            foreach (questCompletaItem qci in quest.questCompletaItem)
            {
                bool foundItemInPlayersInventory = false;

                // Check each item in the player's inventory, to see if they have it, and enough of it
                foreach (itemInventario ii in inventario)
                {
                    if (ii.Detalhes.ID == qci.Detalhes.ID) // The player has the item in their inventory
                    {
                        foundItemInPlayersInventory = true;

                        if (ii.Quantidade < qci.Quantidade) // The player does not have enough of this item to complete the quest
                        {
                            return false;
                        }
                    }
                }

                // The player does not have any of this quest completion item in their inventory
                if (!foundItemInPlayersInventory)
                {
                    return false;
                }
            }

            // If we got here, then the player must have all the required items, and enough of them, to complete the quest.
            return true;
        }

        public void RemoveQuestCompletionItems( quest quest )
        {
            foreach (questCompletaItem qci in quest.questCompletaItem)
            {
                foreach (itemInventario ii in inventario)
                {
                    if (ii.Detalhes.ID == qci.Detalhes.ID)
                    {
                        // Subtract the quantity from the player's inventory that was needed to complete the quest
                        ii.Quantidade -= qci.Quantidade;
                        break;
                    }
                }
            }
        }

        public void AddItemToInventory( item itemToAdd )
        {
            foreach (itemInventario ii in inventario)
            {
                if (ii.Detalhes.ID == itemToAdd.ID)
                {
                    // They have the item in their inventory, so increase the quantity by one
                    ii.Quantidade++;

                    return; // We added the item, and are done, so get out of this function
                }
            }

            // They didn't have the item, so add it to their inventory, with a quantity of 1
            inventario.Add(new itemInventario(itemToAdd, 1));
        }

        public void MarkQuestCompleted( quest quest )
        {
            // Find the quest in the player's quest list
            foreach (missaoPlayer pq in Missoes)
            {
                if (pq.Detalhes.ID == quest.ID)
                {
                    // Mark it as completed
                    pq.concluida = true;

                    return; // We found the quest, and marked it complete, so get out of this function
                }
            }
        }
    }
}