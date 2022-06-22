namespace LetsInvest.Controls
{
    partial class UcInvestimento
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTipoRenda = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNivelRisco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRentabilidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCorretoras = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCorretoraModelo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecoCota = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrazoMinimoRetirada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimularInvestimento = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlCorretoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(5, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo:";
            // 
            // lblTipoRenda
            // 
            this.lblTipoRenda.AutoSize = true;
            this.lblTipoRenda.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipoRenda.Location = new System.Drawing.Point(51, 93);
            this.lblTipoRenda.Name = "lblTipoRenda";
            this.lblTipoRenda.Size = new System.Drawing.Size(83, 17);
            this.lblTipoRenda.TabIndex = 4;
            this.lblTipoRenda.Text = "Renda Fixa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(4, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Risco:";
            // 
            // lblNivelRisco
            // 
            this.lblNivelRisco.AutoSize = true;
            this.lblNivelRisco.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblNivelRisco.Location = new System.Drawing.Point(51, 117);
            this.lblNivelRisco.Name = "lblNivelRisco";
            this.lblNivelRisco.Size = new System.Drawing.Size(46, 17);
            this.lblNivelRisco.TabIndex = 6;
            this.lblNivelRisco.Text = "Baixo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescricao.Location = new System.Drawing.Point(7, 47);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(226, 38);
            this.txtDescricao.TabIndex = 7;
            this.txtDescricao.Text = "Certificado de depósito bancário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(3, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rentabilidade a. a.:";
            // 
            // lblRentabilidade
            // 
            this.lblRentabilidade.AutoSize = true;
            this.lblRentabilidade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblRentabilidade.Location = new System.Drawing.Point(158, 141);
            this.lblRentabilidade.Name = "lblRentabilidade";
            this.lblRentabilidade.Size = new System.Drawing.Size(48, 17);
            this.lblRentabilidade.TabIndex = 9;
            this.lblRentabilidade.Text = "13,5%";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlCorretoras);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPrecoCota);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblPrazoMinimoRetirada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSimularInvestimento);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblRentabilidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblNivelRisco);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTipoRenda);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 329);
            this.panel1.TabIndex = 0;
            // 
            // pnlCorretoras
            // 
            this.pnlCorretoras.AutoScroll = true;
            this.pnlCorretoras.Controls.Add(this.label9);
            this.pnlCorretoras.Controls.Add(this.lblCorretoraModelo);
            this.pnlCorretoras.Location = new System.Drawing.Point(92, 220);
            this.pnlCorretoras.Name = "pnlCorretoras";
            this.pnlCorretoras.Size = new System.Drawing.Size(133, 47);
            this.pnlCorretoras.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(5, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Modal Mais";
            this.label9.Click += new System.EventHandler(this.lblCorretora_Click);
            // 
            // lblCorretoraModelo
            // 
            this.lblCorretoraModelo.AutoSize = true;
            this.lblCorretoraModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCorretoraModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretoraModelo.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblCorretoraModelo.Location = new System.Drawing.Point(5, 4);
            this.lblCorretoraModelo.Name = "lblCorretoraModelo";
            this.lblCorretoraModelo.Size = new System.Drawing.Size(84, 16);
            this.lblCorretoraModelo.TabIndex = 20;
            this.lblCorretoraModelo.Text = "Modal Mais";
            this.lblCorretoraModelo.Click += new System.EventHandler(this.lblCorretora_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(3, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Corretoras:";
            // 
            // lblPrecoCota
            // 
            this.lblPrecoCota.AutoSize = true;
            this.lblPrecoCota.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrecoCota.Location = new System.Drawing.Point(100, 195);
            this.lblPrecoCota.Name = "lblPrecoCota";
            this.lblPrecoCota.Size = new System.Drawing.Size(100, 17);
            this.lblPrecoCota.TabIndex = 15;
            this.lblPrecoCota.Text = "R$ 100.000,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço Cota:";
            // 
            // lblPrazoMinimoRetirada
            // 
            this.lblPrazoMinimoRetirada.AutoSize = true;
            this.lblPrazoMinimoRetirada.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrazoMinimoRetirada.Location = new System.Drawing.Point(123, 169);
            this.lblPrazoMinimoRetirada.Name = "lblPrazoMinimoRetirada";
            this.lblPrazoMinimoRetirada.Size = new System.Drawing.Size(64, 17);
            this.lblPrazoMinimoRetirada.TabIndex = 13;
            this.lblPrazoMinimoRetirada.Text = "180 dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(3, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prazo Retirada:";
            // 
            // btnSimularInvestimento
            // 
            this.btnSimularInvestimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSimularInvestimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimularInvestimento.FlatAppearance.BorderSize = 0;
            this.btnSimularInvestimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimularInvestimento.Location = new System.Drawing.Point(12, 280);
            this.btnSimularInvestimento.Name = "btnSimularInvestimento";
            this.btnSimularInvestimento.Size = new System.Drawing.Size(213, 39);
            this.btnSimularInvestimento.TabIndex = 11;
            this.btnSimularInvestimento.Text = "Simular";
            this.btnSimularInvestimento.UseVisualStyleBackColor = false;
            this.btnSimularInvestimento.Click += new System.EventHandler(this.btnSimularInvestimento_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(239)))), ((int)(((byte)(168)))));
            this.txtNome.Location = new System.Drawing.Point(3, 3);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(230, 38);
            this.txtNome.TabIndex = 10;
            this.txtNome.Text = "CDB";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UcInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcInvestimento";
            this.Size = new System.Drawing.Size(242, 335);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCorretoras.ResumeLayout(false);
            this.pnlCorretoras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTipoRenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNivelRisco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRentabilidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSimularInvestimento;
        private System.Windows.Forms.Label lblPrecoCota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrazoMinimoRetirada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCorretoras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCorretoraModelo;
        private System.Windows.Forms.ToolTip ttp;
    }
}
