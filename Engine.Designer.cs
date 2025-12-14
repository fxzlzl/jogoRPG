namespace jogoRPG
{
    partial class Engine
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Engine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPontosDeVida = new System.Windows.Forms.Label();
            this.lblOuro = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboArmas = new System.Windows.Forms.ComboBox();
            this.cboPoção = new System.Windows.Forms.ComboBox();
            this.btnUsarArma = new System.Windows.Forms.Button();
            this.btnUsarPoção = new System.Windows.Forms.Button();
            this.btnSul = new System.Windows.Forms.Button();
            this.btnOeste = new System.Windows.Forms.Button();
            this.btnLeste = new System.Windows.Forms.Button();
            this.btnNorte = new System.Windows.Forms.Button();
            this.rtbLocal = new System.Windows.Forms.RichTextBox();
            this.rtbMensagens = new System.Windows.Forms.RichTextBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.dgvMissoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos de vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experiência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nível:";
            // 
            // lblPontosDeVida
            // 
            this.lblPontosDeVida.AutoSize = true;
            this.lblPontosDeVida.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.lblPontosDeVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPontosDeVida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPontosDeVida.Location = new System.Drawing.Point(116, 20);
            this.lblPontosDeVida.Name = "lblPontosDeVida";
            this.lblPontosDeVida.Size = new System.Drawing.Size(49, 14);
            this.lblPontosDeVida.TabIndex = 4;
            this.lblPontosDeVida.Text = "label5";
            // 
            // lblOuro
            // 
            this.lblOuro.AutoSize = true;
            this.lblOuro.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.lblOuro.ForeColor = System.Drawing.Color.Yellow;
            this.lblOuro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOuro.Location = new System.Drawing.Point(110, 46);
            this.lblOuro.Name = "lblOuro";
            this.lblOuro.Size = new System.Drawing.Size(49, 14);
            this.lblOuro.TabIndex = 5;
            this.lblOuro.Text = "label6";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.lblExp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblExp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblExp.Location = new System.Drawing.Point(110, 74);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(49, 14);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "label7";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("JetBrains Mono", 8.249999F);
            this.lblNivel.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblNivel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNivel.Location = new System.Drawing.Point(110, 100);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(49, 14);
            this.lblNivel.TabIndex = 7;
            this.lblNivel.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(601, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selecione sua ação";
            // 
            // cboArmas
            // 
            this.cboArmas.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboArmas.FormattingEnabled = true;
            this.cboArmas.Location = new System.Drawing.Point(369, 559);
            this.cboArmas.Name = "cboArmas";
            this.cboArmas.Size = new System.Drawing.Size(121, 25);
            this.cboArmas.TabIndex = 9;
            // 
            // cboPoção
            // 
            this.cboPoção.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboPoção.FormattingEnabled = true;
            this.cboPoção.Location = new System.Drawing.Point(369, 593);
            this.cboPoção.Name = "cboPoção";
            this.cboPoção.Size = new System.Drawing.Size(121, 25);
            this.cboPoção.TabIndex = 10;
            // 
            // btnUsarArma
            // 
            this.btnUsarArma.AutoSize = true;
            this.btnUsarArma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsarArma.FlatAppearance.BorderSize = 0;
            this.btnUsarArma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsarArma.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnUsarArma.ForeColor = System.Drawing.Color.White;
            this.btnUsarArma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUsarArma.Location = new System.Drawing.Point(620, 559);
            this.btnUsarArma.Name = "btnUsarArma";
            this.btnUsarArma.Size = new System.Drawing.Size(85, 27);
            this.btnUsarArma.TabIndex = 11;
            this.btnUsarArma.Text = "Usar Arma";
            this.btnUsarArma.UseVisualStyleBackColor = false;
            this.btnUsarArma.Click += new System.EventHandler(this.btnUsarArma_Click);
            // 
            // btnUsarPoção
            // 
            this.btnUsarPoção.AutoSize = true;
            this.btnUsarPoção.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUsarPoção.FlatAppearance.BorderSize = 0;
            this.btnUsarPoção.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsarPoção.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnUsarPoção.ForeColor = System.Drawing.Color.White;
            this.btnUsarPoção.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUsarPoção.Location = new System.Drawing.Point(620, 588);
            this.btnUsarPoção.Name = "btnUsarPoção";
            this.btnUsarPoção.Size = new System.Drawing.Size(85, 27);
            this.btnUsarPoção.TabIndex = 12;
            this.btnUsarPoção.Text = "Usar Poção";
            this.btnUsarPoção.UseVisualStyleBackColor = false;
            this.btnUsarPoção.Click += new System.EventHandler(this.btnUsarPoção_Click);
            // 
            // btnSul
            // 
            this.btnSul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSul.AutoSize = true;
            this.btnSul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSul.FlatAppearance.BorderSize = 0;
            this.btnSul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSul.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSul.ForeColor = System.Drawing.Color.White;
            this.btnSul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSul.Location = new System.Drawing.Point(493, 493);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(94, 27);
            this.btnSul.TabIndex = 13;
            this.btnSul.Text = "Ir Para Sul";
            this.btnSul.UseMnemonic = false;
            this.btnSul.UseVisualStyleBackColor = false;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // btnOeste
            // 
            this.btnOeste.AutoSize = true;
            this.btnOeste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnOeste.FlatAppearance.BorderSize = 0;
            this.btnOeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOeste.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnOeste.ForeColor = System.Drawing.Color.White;
            this.btnOeste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOeste.Location = new System.Drawing.Point(396, 460);
            this.btnOeste.Name = "btnOeste";
            this.btnOeste.Size = new System.Drawing.Size(94, 27);
            this.btnOeste.TabIndex = 14;
            this.btnOeste.Text = "Ir Para Oeste";
            this.btnOeste.UseVisualStyleBackColor = false;
            this.btnOeste.Click += new System.EventHandler(this.btnOeste_Click);
            // 
            // btnLeste
            // 
            this.btnLeste.AutoSize = true;
            this.btnLeste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLeste.FlatAppearance.BorderSize = 0;
            this.btnLeste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeste.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnLeste.ForeColor = System.Drawing.Color.White;
            this.btnLeste.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLeste.Location = new System.Drawing.Point(592, 460);
            this.btnLeste.Name = "btnLeste";
            this.btnLeste.Size = new System.Drawing.Size(91, 27);
            this.btnLeste.TabIndex = 15;
            this.btnLeste.Text = "Ir Para Leste";
            this.btnLeste.UseVisualStyleBackColor = false;
            this.btnLeste.Click += new System.EventHandler(this.btnLeste_Click);
            // 
            // btnNorte
            // 
            this.btnNorte.AutoSize = true;
            this.btnNorte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNorte.FlatAppearance.BorderSize = 0;
            this.btnNorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNorte.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNorte.ForeColor = System.Drawing.Color.White;
            this.btnNorte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNorte.Location = new System.Drawing.Point(493, 427);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(94, 27);
            this.btnNorte.TabIndex = 16;
            this.btnNorte.Text = "Ir Para Norte";
            this.btnNorte.UseMnemonic = false;
            this.btnNorte.UseVisualStyleBackColor = false;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // rtbLocal
            // 
            this.rtbLocal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbLocal.Location = new System.Drawing.Point(347, 19);
            this.rtbLocal.Name = "rtbLocal";
            this.rtbLocal.ReadOnly = true;
            this.rtbLocal.Size = new System.Drawing.Size(360, 105);
            this.rtbLocal.TabIndex = 17;
            this.rtbLocal.Text = "";
            // 
            // rtbMensagens
            // 
            this.rtbMensagens.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbMensagens.Location = new System.Drawing.Point(347, 130);
            this.rtbMensagens.Name = "rtbMensagens";
            this.rtbMensagens.ReadOnly = true;
            this.rtbMensagens.Size = new System.Drawing.Size(360, 286);
            this.rtbMensagens.TabIndex = 18;
            this.rtbMensagens.Text = "";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventario.Enabled = false;
            this.dgvInventario.Location = new System.Drawing.Point(16, 130);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.Size = new System.Drawing.Size(312, 309);
            this.dgvInventario.TabIndex = 19;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // dgvMissoes
            // 
            this.dgvMissoes.AllowUserToAddRows = false;
            this.dgvMissoes.AllowUserToDeleteRows = false;
            this.dgvMissoes.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMissoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMissoes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMissoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMissoes.Enabled = false;
            this.dgvMissoes.Location = new System.Drawing.Point(16, 446);
            this.dgvMissoes.MultiSelect = false;
            this.dgvMissoes.Name = "dgvMissoes";
            this.dgvMissoes.ReadOnly = true;
            this.dgvMissoes.RowHeadersVisible = false;
            this.dgvMissoes.Size = new System.Drawing.Size(312, 189);
            this.dgvMissoes.TabIndex = 20;
            // 
            // Engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(719, 649);
            this.Controls.Add(this.dgvMissoes);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.rtbMensagens);
            this.Controls.Add(this.rtbLocal);
            this.Controls.Add(this.btnNorte);
            this.Controls.Add(this.btnLeste);
            this.Controls.Add(this.btnOeste);
            this.Controls.Add(this.btnSul);
            this.Controls.Add(this.btnUsarPoção);
            this.Controls.Add(this.btnUsarArma);
            this.Controls.Add(this.cboPoção);
            this.Controls.Add(this.cboArmas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblOuro);
            this.Controls.Add(this.lblPontosDeVida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Engine";
            this.Text = "My Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPontosDeVida;
        private System.Windows.Forms.Label lblOuro;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboArmas;
        private System.Windows.Forms.ComboBox cboPoção;
        private System.Windows.Forms.Button btnUsarArma;
        private System.Windows.Forms.Button btnUsarPoção;
        private System.Windows.Forms.Button btnSul;
        private System.Windows.Forms.Button btnOeste;
        private System.Windows.Forms.Button btnLeste;
        private System.Windows.Forms.Button btnNorte;
        private System.Windows.Forms.RichTextBox rtbLocal;
        private System.Windows.Forms.RichTextBox rtbMensagens;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridView dgvMissoes;
    }
}
