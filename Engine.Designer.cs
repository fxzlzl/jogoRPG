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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPontosDeVida = new System.Windows.Forms.Label();
            this.lblOuro = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pontos de vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ouro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experiência:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nível:";
            // 
            // lblPontosDeVida
            // 
            this.lblPontosDeVida.AutoSize = true;
            this.lblPontosDeVida.Location = new System.Drawing.Point(110, 20);
            this.lblPontosDeVida.Name = "lblPontosDeVida";
            this.lblPontosDeVida.Size = new System.Drawing.Size(35, 13);
            this.lblPontosDeVida.TabIndex = 4;
            this.lblPontosDeVida.Text = "label5";
            // 
            // lblOuro
            // 
            this.lblOuro.AutoSize = true;
            this.lblOuro.Location = new System.Drawing.Point(110, 46);
            this.lblOuro.Name = "lblOuro";
            this.lblOuro.Size = new System.Drawing.Size(35, 13);
            this.lblOuro.TabIndex = 5;
            this.lblOuro.Text = "label6";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(110, 74);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(35, 13);
            this.lblExp.TabIndex = 6;
            this.lblExp.Text = "label7";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(110, 100);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(35, 13);
            this.lblNivel.TabIndex = 7;
            this.lblNivel.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Selecione sua ação";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(369, 559);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 593);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // btnUsarArma
            // 
            this.btnUsarArma.Location = new System.Drawing.Point(620, 559);
            this.btnUsarArma.Name = "btnUsarArma";
            this.btnUsarArma.Size = new System.Drawing.Size(75, 23);
            this.btnUsarArma.TabIndex = 11;
            this.btnUsarArma.Text = "Usar";
            this.btnUsarArma.UseVisualStyleBackColor = true;
            this.btnUsarArma.Click += new System.EventHandler(this.btnUsarArma_Click);
            // 
            // btnUsarPoção
            // 
            this.btnUsarPoção.Location = new System.Drawing.Point(620, 593);
            this.btnUsarPoção.Name = "btnUsarPoção";
            this.btnUsarPoção.Size = new System.Drawing.Size(75, 23);
            this.btnUsarPoção.TabIndex = 12;
            this.btnUsarPoção.Text = "Usar";
            this.btnUsarPoção.UseVisualStyleBackColor = true;
            this.btnUsarPoção.Click += new System.EventHandler(this.btnUsarPoção_Click);
            // 
            // btnSul
            // 
            this.btnSul.Location = new System.Drawing.Point(493, 487);
            this.btnSul.Name = "btnSul";
            this.btnSul.Size = new System.Drawing.Size(75, 23);
            this.btnSul.TabIndex = 13;
            this.btnSul.Text = "Ir Para Sul";
            this.btnSul.UseVisualStyleBackColor = true;
            this.btnSul.Click += new System.EventHandler(this.btnSul_Click);
            // 
            // btnOeste
            // 
            this.btnOeste.Location = new System.Drawing.Point(408, 460);
            this.btnOeste.Name = "btnOeste";
            this.btnOeste.Size = new System.Drawing.Size(79, 23);
            this.btnOeste.TabIndex = 14;
            this.btnOeste.Text = "Ir Para Oeste";
            this.btnOeste.UseVisualStyleBackColor = true;
            this.btnOeste.Click += new System.EventHandler(this.btnOeste_Click);
            // 
            // btnLeste
            // 
            this.btnLeste.Location = new System.Drawing.Point(573, 460);
            this.btnLeste.Name = "btnLeste";
            this.btnLeste.Size = new System.Drawing.Size(75, 23);
            this.btnLeste.TabIndex = 15;
            this.btnLeste.Text = "Ir Para Leste";
            this.btnLeste.UseVisualStyleBackColor = true;
            this.btnLeste.Click += new System.EventHandler(this.btnLeste_Click);
            // 
            // btnNorte
            // 
            this.btnNorte.Location = new System.Drawing.Point(493, 433);
            this.btnNorte.Name = "btnNorte";
            this.btnNorte.Size = new System.Drawing.Size(75, 23);
            this.btnNorte.TabIndex = 16;
            this.btnNorte.Text = "Ir Para Norte";
            this.btnNorte.UseVisualStyleBackColor = true;
            this.btnNorte.Click += new System.EventHandler(this.btnNorte_Click);
            // 
            // rtbLocal
            // 
            this.rtbLocal.Location = new System.Drawing.Point(347, 19);
            this.rtbLocal.Name = "rtbLocal";
            this.rtbLocal.ReadOnly = true;
            this.rtbLocal.Size = new System.Drawing.Size(360, 105);
            this.rtbLocal.TabIndex = 17;
            this.rtbLocal.Text = "";
            // 
            // rtbMensagens
            // 
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
            this.dgvInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventario.Enabled = false;
            this.dgvInventario.Location = new System.Drawing.Point(16, 130);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.Size = new System.Drawing.Size(312, 309);
            this.dgvInventario.TabIndex = 19;
            // 
            // dgvMissoes
            // 
            this.dgvMissoes.AllowUserToAddRows = false;
            this.dgvMissoes.AllowUserToDeleteRows = false;
            this.dgvMissoes.AllowUserToResizeRows = false;
            this.dgvMissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.ClientSize = new System.Drawing.Size(719, 651);
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
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblOuro);
            this.Controls.Add(this.lblPontosDeVida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
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

