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
            // Engine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
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
    }
}

