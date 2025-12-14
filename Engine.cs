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
            lblOuro.Text = _player.ouro.ToString();
            lblExp.Text = _player.EXP.ToString();
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
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                // Não encontramos o item no inventário; exibe mensagem e cancela a movimentação
                rtbMensagens.Text += "Você precisa de um(a) " + newLocation.ItemNecessario.Nome + " para entrar aqui, volte com isso em mãos." + Environment.NewLine;
                return;
            }
            // Atualiza a localização atual do jogador
            _player.localAtual = newLocation;

            // Exibe/oculta botões de movimento disponíveis
            btnNorte.Visible = ( newLocation.localNorte != null );
            btnLeste.Visible = ( newLocation.localLeste != null );
            btnSul.Visible = ( newLocation.localSul != null );
            btnOeste.Visible = ( newLocation.localOeste != null );

            // Exibe nome e descrição da localização atual
            rtbLocal.Text = newLocation.Nome + Environment.NewLine;
            rtbLocal.Text += newLocation.Descricao + Environment.NewLine;

            // Cura completamente o jogador
            _player.hpAtual = _player.hpMax;

            // Atualiza os Pontos de Vida na UI
            lblPontosDeVida.Text = _player.hpAtual.ToString();

            // O local tem uma missão?
            if (newLocation.MissaoDisponivel != null)
            {
                // Verifica se o jogador já tem a missão e se a concluiu
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.MissaoDisponivel);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.MissaoDisponivel);

                // Verifica se o jogador já possui a missão
                if (playerAlreadyHasQuest)
                {
                    // Se o jogador ainda não concluiu a missão
                    if (!playerAlreadyCompletedQuest)
                    {
                        // Verifica se o jogador tem todos os itens necessários para completar a missão
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.MissaoDisponivel);

                        // O jogador possui todos os itens necessários para completar a missão
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Exibe mensagem
                            rtbMensagens.Text += Environment.NewLine;
                            rtbMensagens.Text += "Você completou uma '" + newLocation.MissaoDisponivel.Nome + "' quest." + Environment.NewLine;

                            // Remove itens da missão do inventário
                            _player.RemoveQuestCompletionItems(newLocation.MissaoDisponivel);

                            // Concede recompensas da missão
                            rtbMensagens.Text += "Você recebe: " + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaXP.ToString() + " pontos de XP" + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaOuro.ToString() + " ouro" + Environment.NewLine;
                            rtbMensagens.Text += newLocation.MissaoDisponivel.RecompensaItem.Nome + Environment.NewLine;
                            rtbMensagens.Text += Environment.NewLine;

                            _player.EXP += newLocation.MissaoDisponivel.RecompensaXP;
                            _player.ouro += newLocation.MissaoDisponivel.RecompensaOuro;

                            // Adiciona o item de recompensa ao inventário do jogador
                            _player.AddItemToInventory(newLocation.MissaoDisponivel.RecompensaItem);


                            // Marca a missão como concluída
                            // Encontra a missão na lista de missões do jogador

                            _player.MarkQuestCompleted(newLocation.MissaoDisponivel);
                        }
                    }
                }
                else
                {
                    // O jogador ainda não possui a missão

                    // Exibe as mensagens
                    rtbMensagens.Text += "🎯 " + newLocation.MissaoDisponivel.Nome + " 🎯" + Environment.NewLine;
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

                    // Adiciona a missão à lista de missões do jogador
                    _player.Missoes.Add(new missaoPlayer(newLocation.MissaoDisponivel));
                }
            }

            // O local tem um monstro?
            if (newLocation.monstrosAqui != null)
            {
                rtbMensagens.Text += "Você vê um(a) " + newLocation.monstrosAqui.Name + Environment.NewLine;

                // Cria um novo monstro, usando os valores do monstro padrão na lista mundo.Monstro
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
            UpdateInventoryListInUI();

            // Refresh player's quest list
            UpdateQuestListInUI();

            // Refresh player's weapons combobox
            UpdateWeaponListInUI();

            // Refresh player's potions combobox
            UpdatePotionListInUI();
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

        private void dgvInventario_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {

        }
        private void UpdateInventoryListInUI()
        {
            dgvInventario.RowHeadersVisible = false;

            dgvInventario.ColumnCount = 2;
            dgvInventario.Columns[0].Name = "Name";
            dgvInventario.Columns[0].Width = 197;
            dgvInventario.Columns[1].Name = "Quantity";

            dgvInventario.Rows.Clear();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Quantidade > 0)
                {
                    dgvInventario.Rows.Add(new[] { inventoryItem.Detalhes.Nome, inventoryItem.Quantidade.ToString() });
                }
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvMissoes.RowHeadersVisible = false;

            dgvMissoes.ColumnCount = 2;
            dgvMissoes.Columns[0].Name = "Name";
            dgvMissoes.Columns[0].Width = 197;
            dgvMissoes.Columns[1].Name = "Done?";

            dgvMissoes.Rows.Clear();

            foreach (missaoPlayer playerQuest in _player.Missoes)
            {
                dgvMissoes.Rows.Add(new[] { playerQuest.Detalhes.Nome, playerQuest.concluida.ToString() });
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<arma> weapons = new List<arma>();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Detalhes is arma)
                {
                    if (inventoryItem.Quantidade> 0)
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
                cboArmas.DisplayMember = "Name";
                cboArmas.ValueMember = "ID";

                cboArmas.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<healingPot> healingPotions = new List<healingPot>();

            foreach (itemInventario inventoryItem in _player.inventario)
            {
                if (inventoryItem.Detalhes is healingPot)
                {
                    if (inventoryItem.Quantidade> 0)
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
    }
}