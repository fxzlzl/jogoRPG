using jogoRPG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoRPG
{
    public partial class Engine : Form
    {
        private Player _player;
        private monstros _currentMonster;

        public Engine()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0, 1);
            MoveTo(mundo.localByID(mundo.local_ID_HOME));
            _player.inventario.Add(new itemInventario(mundo.ItemByID(mundo.ITEM_ID_RUSTY_SWORD), 1));

            lblPontosDeVida.Text = _player.hpAtual.ToString();
            lblOuro.Text = _player.Ouro.ToString();
            lblExp.Text = _player.xPontos.ToString();
            lblNivel.Text = _player.nivel.ToString();
        }

        private void btnNorte_Click( object sender, EventArgs e )
        {
            MoveTo(_player.localAtual.localNorte);
        }

        private void btnLeste_Click( object sender, EventArgs e )
        {
            MoveTo(_player.localAtual.localLeste);
        }

        private void btnSul_Click( object sender, EventArgs e )
        {
            MoveTo(_player.localAtual.localSul);
        }

        private void btnOeste_Click( object sender, EventArgs e )
        {
            MoveTo(_player.localAtual.localOeste);
        }

        private void MoveTo( local newLocation )
        {
            //Does the location have any required items
            if (newLocation.ItemNecessario != null)
            {
                // See if the player has the required item in their inventory
                bool playerHasRequiredItem = false;

                foreach (itemInventario ii in _player.inventario)
                {
                    if (ii.Detalhes.ID == newLocation.ItemNecessario.ID)
                    {
                        // We found the required item
                        playerHasRequiredItem = true;
                        break; // Exit out of the foreach loop
                    }
                }

                if (!playerHasRequiredItem)
                {
                    // We didn't find the required item in their inventory, so display a message and stop trying to move
                    rtbMensagens.Text += "Você precisa de um(a) " + newLocation.ItemNecessario.Nome + " para entrar aqui, volte com isso em mãos." + Environment.NewLine;
                    return;
                }
            }

            // Update the player's current location
            _player.localAtual = newLocation;

            // Show/hide available movement buttons
            btnNorte.Visible = ( newLocation.localNorte != null );
            btnLeste.Visible = ( newLocation.localLeste != null );
            btnSul.Visible = ( newLocation.localSul != null );
            btnOeste.Visible = ( newLocation.localOeste != null );

            // Display current location name and description
            rtbLocal.Text = newLocation.Nome + Environment.NewLine;
            rtbLocal.Text += newLocation.Descricao + Environment.NewLine;

            // Completely heal the player
            _player.hpAtual = _player.hpMax;

            // Update Hit Points in UI
            lblPontosDeVida.Text = _player.hpAtual.ToString();

            // Does the location have a quest?
            if (newLocation.MissaoDisponivel != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = false;
                bool playerAlreadyCompletedQuest = false;

                foreach (missaoPlayer playerQuest in _player.Missoes)
                {
                    if (playerQuest.Detalhes.ID == newLocation.MissaoDisponivel.ID)
                    {
                        playerAlreadyHasQuest = true;

                        if (playerQuest.concluida)
                        {
                            playerAlreadyCompletedQuest = true;
                        }
                    }
                }

                // See if the player already has the quest
                if (playerAlreadyHasQuest)
                {
                    // If the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool playerHasAllItemsToCompleteQuest = true;

                        foreach (questCompletaItem qci in newLocation.MissaoDisponivel.questCompletaItem)
                        {
                            bool foundItemInPlayersInventory = false;

                            // Check each item in the player's inventory, to see if they have it, and enough of it
                            foreach (itemInventario ii in _player.inventario)
                            {
                                // The player has this item in their inventory
                                if (ii.Detalhes.ID == qci.Detalhes.ID)
                                {
                                    foundItemInPlayersInventory = true;

                                    if (ii.Quantidade < qci.Quantidade)
                                    {
                                        // The player does not have enough of this item to complete the quest
                                        playerHasAllItemsToCompleteQuest = false;

                                        // There is no reason to continue checking for the other quest completion items
                                        break;
                                    }

                                    // We found the item, so don't check the rest of the player's inventory
                                    break;
                                }
                            }

                            // If we didn't find the required item, set our variable and stop looking for other items
                            if (!foundItemInPlayersInventory)
                            {
                                // The player does not have this item in their inventory
                                playerHasAllItemsToCompleteQuest = false;

                                // There is no reason to continue checking for the other quest completion items
                                break;
                            }
                        }

                        // The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Display message
                            rtbMensagens.Text += Environment.NewLine;
                            rtbMensagens.Text += "Você completou uma '" + newLocation.MissaoDisponivel.Nome + "' quest." + Environment.NewLine;

                            // Remove quest items from inventory
                            foreach (questCompletaItem qci in newLocation.MissaoDisponivel.questCompletaItem)
                            {
                                foreach (itemInventario ii in _player.inventario)
                                {
                                    if (ii.Detalhes.ID == qci.Detalhes.ID)
                                    {
                                        // Subtract the Quantidade from the player's inventory that was needed to complete the quest
                                        ii.Quantidade -= qci.Quantidade;
                                        break;
                                    }
                                }
                            }

                            // Give quest rewards
                            rtbMensagens.Text += "Você recebe: " + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaXP.ToString() + " pontos de XP" + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaOuro.ToString() + " ouro" + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaItem.Nome + Environment.NewLine;
                            rtbMensagens.Text += Environment.NewLine;

                            _player.xPontos += newLocation.MissaoDisponivel.RecompensaXP;
                            _player.Ouro += newLocation.MissaoDisponivel.RecompensaOuro;

                            // Add the reward item to the player's inventory
                            bool addedItemToPlayerInventory = false;

                            foreach (itemInventario ii in _player.inventario)
                            {
                                if (ii.Detalhes.ID == newLocation.MissaoDisponivel.RecompensaItem.ID)
                                {
                                    // They have the item in their inventory, so increase the Quantidade by one
                                    ii.Quantidade++;

                                    addedItemToPlayerInventory = true;

                                    break;
                                }
                            }

                            // They didn't have the item, so add it to their inventory, with a Quantidade of 1
                            if (!addedItemToPlayerInventory)
                            {
                                _player.inventario.Add(new itemInventario(newLocation.MissaoDisponivel.RecompensaItem, 1));
                            }

                            // Mark the quest as completed
                            // Find the quest in the player's quest list
                            foreach (missaoPlayer pq in _player.Missoes)
                            {
                                if (pq.Detalhes.ID == newLocation.MissaoDisponivel.ID)
                                {
                                    // Mark it as completed
                                    pq.concluida = true;

                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    // The player does not already have the quest

                    // Display the messages
                    rtbMensagens.Text += "Missão! " + newLocation.MissaoDisponivel.Nome + " quest." + Environment.NewLine;
                    rtbMensagens.Text += newLocation.MissaoDisponivel.Descricao + Environment.NewLine;
                    rtbMensagens.Text += "Para completar, retorne com:" + Environment.NewLine;
                    foreach (questCompletaItem qci in newLocation.MissaoDisponivel.questCompletaItem)
                    {
                        if (qci.Quantidade == 1)
                        {
                            rtbMensagens.Text += qci.Quantidade.ToString() + " " + qci.Detalhes.Nome + Environment.NewLine;
                        }
                        else
                        {
                            rtbMensagens.Text += qci.Quantidade.ToString() + " " + qci.Detalhes.NomePlural + Environment.NewLine;
                        }
                    }
                    rtbMensagens.Text += Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Missoes.Add(new missaoPlayer(newLocation.MissaoDisponivel));
                }
            }

            // Does the location have a monster?
            if (newLocation.monstrosAqui != null)
            {
                rtbMensagens.Text += "Você vê um(a) " + newLocation.monstrosAqui.Name + Environment.NewLine;

                // Make a new monster, using the values from the standard monster in the mundo.Monster list
                monstros standardMonster = mundo.monstrosByID(newLocation.monstrosAqui.ID);

                _currentMonster = new monstros(standardMonster.ID, standardMonster.Name, standardMonster.MaxDMG,
                    standardMonster.recEXP, standardMonster.recOuro, standardMonster.hpAtual, standardMonster.hpMax);

                foreach (itemLooteado lootItem in standardMonster.tabelaLoot)
                {
                    _currentMonster.tabelaLoot.Add(lootItem);
                }

                cboPoção.Visible = true;
                cboArmas.Visible = true;
                btnUsarArma.Visible = true;
                btnUsarPoção.Visible = true;
            }
            else
            {
                _currentMonster = null;

                cboPoção.Visible = false;
                cboArmas.Visible = false;
                btnUsarArma.Visible = false;
                btnUsarPoção.Visible = false;
            }

            // Refresh player's inventory list
            dgvInventario.RowHeadersVisible = false;

            dgvInventario.ColumnCount = 2;
            dgvInventario.Columns[0].Name = "Nome";
            dgvInventario.Columns[0].Width = 197;
            dgvInventario.Columns[1].Name = "Quantidade";

            dgvInventario.Rows.Clear();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Quantidade > 0)
                {
                    dgvInventario.Rows.Add(new[] { inventoryItem.Detalhes.Nome, inventoryItem.Quantidade.ToString() });
                }
            }

            // Refresh player's quest list
            dgvMissoes.RowHeadersVisible = false;

            dgvMissoes.ColumnCount = 2;
            dgvMissoes.Columns[0].Name = "Nome";
            dgvMissoes.Columns[0].Width = 197;
            dgvMissoes.Columns[1].Name = "Feito?";

            dgvMissoes.Rows.Clear();

            foreach (missaoPlayer playerQuest in _player.Missoes)
            {
                dgvMissoes.Rows.Add(new[] { playerQuest.Detalhes.Nome, playerQuest.concluida.ToString() });
            }

            // Refresh player's weapons combobox
            List<arma> weapons = new List<arma>();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Detalhes is arma)
                {
                    if (inventoryItem.Quantidade > 0)
                    {
                        weapons.Add((arma)inventoryItem.Detalhes);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboArmas.Visible = false;
                btnUsarArma.Visible = false;
            }
            else
            {
                cboArmas.DataSource = weapons;
                cboArmas.DisplayMember = "Nome";
                cboArmas.ValueMember = "ID";

                cboArmas.SelectedIndex = 0;
            }

            // Refresh player's potions combobox
            List<healingPot> healingPotions = new List<healingPot>();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Detalhes is healingPot)
                {
                    if (inventoryItem.Quantidade > 0)
                    {
                        healingPotions.Add((healingPot)inventoryItem.Detalhes);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPoção.Visible = false;
                btnUsarPoção.Visible = false;
            }
            else
            {
                cboPoção.DataSource = healingPotions;
                cboPoção.DisplayMember = "Nome";
                cboPoção.ValueMember = "ID";

                cboPoção.SelectedIndex = 0;
            }
        }

        private void btnUsarArma_Click( object sender, EventArgs e )
        {

        }

        private void btnUsarPoção_Click( object sender, EventArgs e )
        {

        }
        private void Form1_Load( object sender, EventArgs e )
        {

        }


    }
}