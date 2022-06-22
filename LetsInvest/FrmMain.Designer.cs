namespace LetsInvest
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClienteEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlInformacoesCliente = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClienteDtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btnClienteEnviar = new System.Windows.Forms.Button();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.pnlQuestionario = new System.Windows.Forms.Panel();
            this.lblQuestaoAtual = new System.Windows.Forms.Label();
            this.btnQuestaoAnterior = new System.Windows.Forms.Button();
            this.btnProximaQuestao = new System.Windows.Forms.Button();
            this.rdnRespostaC = new System.Windows.Forms.RadioButton();
            this.rdnRespostaB = new System.Windows.Forms.RadioButton();
            this.rdnRespostaA = new System.Windows.Forms.RadioButton();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.pnlCarteiraInvestimentos = new System.Windows.Forms.Panel();
            this.pnlItensCarteiraInvestimentos = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblPerfilInvestidorCliente = new System.Windows.Forms.Label();
            this.btnReenviarEmail = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlInformacoesCliente.SuspendLayout();
            this.pnlQuestionario.SuspendLayout();
            this.pnlCarteiraInvestimentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(792, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(179)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LET\'S INVEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(236, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtClienteCPF
            // 
            this.txtClienteCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtClienteCPF.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClienteCPF.Location = new System.Drawing.Point(240, 185);
            this.txtClienteCPF.Margin = new System.Windows.Forms.Padding(20);
            this.txtClienteCPF.Mask = "000,000,000-00";
            this.txtClienteCPF.Name = "txtClienteCPF";
            this.txtClienteCPF.Size = new System.Drawing.Size(126, 27);
            this.txtClienteCPF.TabIndex = 1;
            this.txtClienteCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label4.Location = new System.Drawing.Point(236, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtClienteEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClienteEmail.Location = new System.Drawing.Point(240, 261);
            this.txtClienteEmail.Margin = new System.Windows.Forms.Padding(20);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(291, 27);
            this.txtClienteEmail.TabIndex = 3;
            this.txtClienteEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(402, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dt. Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label5.Location = new System.Drawing.Point(236, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF";
            // 
            // pnlInformacoesCliente
            // 
            this.pnlInformacoesCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.pnlInformacoesCliente.Controls.Add(this.label6);
            this.pnlInformacoesCliente.Controls.Add(this.txtClienteDtNascimento);
            this.pnlInformacoesCliente.Controls.Add(this.btnClienteEnviar);
            this.pnlInformacoesCliente.Controls.Add(this.txtClienteNome);
            this.pnlInformacoesCliente.Controls.Add(this.label5);
            this.pnlInformacoesCliente.Controls.Add(this.label3);
            this.pnlInformacoesCliente.Controls.Add(this.txtClienteEmail);
            this.pnlInformacoesCliente.Controls.Add(this.label4);
            this.pnlInformacoesCliente.Controls.Add(this.txtClienteCPF);
            this.pnlInformacoesCliente.Controls.Add(this.label2);
            this.pnlInformacoesCliente.Location = new System.Drawing.Point(12, 58);
            this.pnlInformacoesCliente.Name = "pnlInformacoesCliente";
            this.pnlInformacoesCliente.Size = new System.Drawing.Size(768, 404);
            this.pnlInformacoesCliente.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(387, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Monte já sua carteira de investimentos conosco!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClienteDtNascimento
            // 
            this.txtClienteDtNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtClienteDtNascimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClienteDtNascimento.Location = new System.Drawing.Point(406, 185);
            this.txtClienteDtNascimento.Margin = new System.Windows.Forms.Padding(20);
            this.txtClienteDtNascimento.Mask = "00/00/0000";
            this.txtClienteDtNascimento.Name = "txtClienteDtNascimento";
            this.txtClienteDtNascimento.Size = new System.Drawing.Size(125, 27);
            this.txtClienteDtNascimento.TabIndex = 2;
            this.txtClienteDtNascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // btnClienteEnviar
            // 
            this.btnClienteEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnClienteEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteEnviar.FlatAppearance.BorderSize = 0;
            this.btnClienteEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteEnviar.Location = new System.Drawing.Point(240, 314);
            this.btnClienteEnviar.Name = "btnClienteEnviar";
            this.btnClienteEnviar.Size = new System.Drawing.Size(291, 43);
            this.btnClienteEnviar.TabIndex = 4;
            this.btnClienteEnviar.Text = "Continuar";
            this.btnClienteEnviar.UseVisualStyleBackColor = false;
            this.btnClienteEnviar.Click += new System.EventHandler(this.btnClienteEnviar_Click);
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtClienteNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtClienteNome.Location = new System.Drawing.Point(240, 111);
            this.txtClienteNome.Margin = new System.Windows.Forms.Padding(20);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(291, 27);
            this.txtClienteNome.TabIndex = 0;
            this.txtClienteNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // pnlQuestionario
            // 
            this.pnlQuestionario.Controls.Add(this.lblQuestaoAtual);
            this.pnlQuestionario.Controls.Add(this.btnQuestaoAnterior);
            this.pnlQuestionario.Controls.Add(this.btnProximaQuestao);
            this.pnlQuestionario.Controls.Add(this.rdnRespostaC);
            this.pnlQuestionario.Controls.Add(this.rdnRespostaB);
            this.pnlQuestionario.Controls.Add(this.rdnRespostaA);
            this.pnlQuestionario.Controls.Add(this.lblPergunta);
            this.pnlQuestionario.Location = new System.Drawing.Point(12, 58);
            this.pnlQuestionario.Name = "pnlQuestionario";
            this.pnlQuestionario.Size = new System.Drawing.Size(768, 404);
            this.pnlQuestionario.TabIndex = 3;
            this.pnlQuestionario.Visible = false;
            // 
            // lblQuestaoAtual
            // 
            this.lblQuestaoAtual.AutoSize = true;
            this.lblQuestaoAtual.Location = new System.Drawing.Point(366, 16);
            this.lblQuestaoAtual.Name = "lblQuestaoAtual";
            this.lblQuestaoAtual.Size = new System.Drawing.Size(43, 21);
            this.lblQuestaoAtual.TabIndex = 7;
            this.lblQuestaoAtual.Text = "1 / 7";
            // 
            // btnQuestaoAnterior
            // 
            this.btnQuestaoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnQuestaoAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestaoAnterior.FlatAppearance.BorderSize = 0;
            this.btnQuestaoAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestaoAnterior.Location = new System.Drawing.Point(15, 357);
            this.btnQuestaoAnterior.Name = "btnQuestaoAnterior";
            this.btnQuestaoAnterior.Size = new System.Drawing.Size(103, 32);
            this.btnQuestaoAnterior.TabIndex = 4;
            this.btnQuestaoAnterior.Text = "Anterior";
            this.btnQuestaoAnterior.UseVisualStyleBackColor = false;
            this.btnQuestaoAnterior.Visible = false;
            this.btnQuestaoAnterior.Click += new System.EventHandler(this.btnQuestaoAnterior_Click);
            // 
            // btnProximaQuestao
            // 
            this.btnProximaQuestao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnProximaQuestao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProximaQuestao.FlatAppearance.BorderSize = 0;
            this.btnProximaQuestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximaQuestao.Location = new System.Drawing.Point(651, 357);
            this.btnProximaQuestao.Name = "btnProximaQuestao";
            this.btnProximaQuestao.Size = new System.Drawing.Size(100, 32);
            this.btnProximaQuestao.TabIndex = 3;
            this.btnProximaQuestao.Text = "Próxima";
            this.btnProximaQuestao.UseVisualStyleBackColor = false;
            this.btnProximaQuestao.Click += new System.EventHandler(this.btnProximaQuestao_Click);
            // 
            // rdnRespostaC
            // 
            this.rdnRespostaC.AutoSize = true;
            this.rdnRespostaC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdnRespostaC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rdnRespostaC.Location = new System.Drawing.Point(15, 247);
            this.rdnRespostaC.Name = "rdnRespostaC";
            this.rdnRespostaC.Size = new System.Drawing.Size(697, 46);
            this.rdnRespostaC.TabIndex = 2;
            this.rdnRespostaC.Text = "c) Tenho formação acadêmica e/ou experiência na área de investimentos e me sinto " +
    "\r\nseguro em tomar minhas decisões de investimento.";
            this.rdnRespostaC.UseVisualStyleBackColor = true;
            this.rdnRespostaC.CheckedChanged += new System.EventHandler(this.rdnRespostaC_CheckedChanged);
            // 
            // rdnRespostaB
            // 
            this.rdnRespostaB.AutoSize = true;
            this.rdnRespostaB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdnRespostaB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rdnRespostaB.Location = new System.Drawing.Point(15, 192);
            this.rdnRespostaB.Name = "rdnRespostaB";
            this.rdnRespostaB.Size = new System.Drawing.Size(709, 46);
            this.rdnRespostaB.TabIndex = 1;
            this.rdnRespostaB.Text = "b) Tenho alguma experiência com investimentos, conheço razoavelmente as regras do" +
    " \r\nmercado financeiro e de capitais, mas prefiro ter orientação.";
            this.rdnRespostaB.UseVisualStyleBackColor = true;
            this.rdnRespostaB.CheckedChanged += new System.EventHandler(this.rdnRespostaB_CheckedChanged);
            // 
            // rdnRespostaA
            // 
            this.rdnRespostaA.AutoSize = true;
            this.rdnRespostaA.Checked = true;
            this.rdnRespostaA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdnRespostaA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.rdnRespostaA.Location = new System.Drawing.Point(17, 137);
            this.rdnRespostaA.Name = "rdnRespostaA";
            this.rdnRespostaA.Size = new System.Drawing.Size(745, 46);
            this.rdnRespostaA.TabIndex = 0;
            this.rdnRespostaA.TabStop = true;
            this.rdnRespostaA.Text = "a) Não conheço ou conheço pouco as regras do mercado financeiro e de capitais e p" +
    "reciso \r\nde orientação.";
            this.rdnRespostaA.UseVisualStyleBackColor = false;
            this.rdnRespostaA.CheckedChanged += new System.EventHandler(this.rdnRespostaA_CheckedChanged);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPergunta.Location = new System.Drawing.Point(13, 66);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(694, 38);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "1. Qual frase melhor representa sua formação e/ou experiência profissional no mer" +
    "cado \r\nfinanceiro?";
            // 
            // pnlCarteiraInvestimentos
            // 
            this.pnlCarteiraInvestimentos.AutoScroll = true;
            this.pnlCarteiraInvestimentos.Controls.Add(this.btnReenviarEmail);
            this.pnlCarteiraInvestimentos.Controls.Add(this.lblPerfilInvestidorCliente);
            this.pnlCarteiraInvestimentos.Controls.Add(this.lblNomeCliente);
            this.pnlCarteiraInvestimentos.Controls.Add(this.label7);
            this.pnlCarteiraInvestimentos.Controls.Add(this.pnlItensCarteiraInvestimentos);
            this.pnlCarteiraInvestimentos.Location = new System.Drawing.Point(12, 58);
            this.pnlCarteiraInvestimentos.Name = "pnlCarteiraInvestimentos";
            this.pnlCarteiraInvestimentos.Size = new System.Drawing.Size(768, 404);
            this.pnlCarteiraInvestimentos.TabIndex = 4;
            this.pnlCarteiraInvestimentos.Visible = false;
            // 
            // pnlItensCarteiraInvestimentos
            // 
            this.pnlItensCarteiraInvestimentos.AutoScroll = true;
            this.pnlItensCarteiraInvestimentos.Location = new System.Drawing.Point(3, 66);
            this.pnlItensCarteiraInvestimentos.Name = "pnlItensCarteiraInvestimentos";
            this.pnlItensCarteiraInvestimentos.Size = new System.Drawing.Size(762, 335);
            this.pnlItensCarteiraInvestimentos.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Perfil de Investidor:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(529, 4);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(63, 19);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Daniel,";
            this.lblNomeCliente.Visible = false;
            // 
            // lblPerfilInvestidorCliente
            // 
            this.lblPerfilInvestidorCliente.AutoSize = true;
            this.lblPerfilInvestidorCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilInvestidorCliente.Location = new System.Drawing.Point(171, 23);
            this.lblPerfilInvestidorCliente.Name = "lblPerfilInvestidorCliente";
            this.lblPerfilInvestidorCliente.Size = new System.Drawing.Size(100, 19);
            this.lblPerfilInvestidorCliente.TabIndex = 3;
            this.lblPerfilInvestidorCliente.Text = "MODERADO";
            // 
            // btnReenviarEmail
            // 
            this.btnReenviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnReenviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReenviarEmail.FlatAppearance.BorderSize = 0;
            this.btnReenviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReenviarEmail.Location = new System.Drawing.Point(563, 14);
            this.btnReenviarEmail.Name = "btnReenviarEmail";
            this.btnReenviarEmail.Size = new System.Drawing.Size(188, 35);
            this.btnReenviarEmail.TabIndex = 5;
            this.btnReenviarEmail.Text = "Reenviar Email";
            this.btnReenviarEmail.UseVisualStyleBackColor = false;
            this.btnReenviarEmail.Click += new System.EventHandler(this.btnReenviarEmail_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(792, 474);
            this.Controls.Add(this.pnlCarteiraInvestimentos);
            this.Controls.Add(this.pnlInformacoesCliente);
            this.Controls.Add(this.pnlQuestionario);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 513);
            this.MinimumSize = new System.Drawing.Size(808, 513);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Invest";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlInformacoesCliente.ResumeLayout(false);
            this.pnlInformacoesCliente.PerformLayout();
            this.pnlQuestionario.ResumeLayout(false);
            this.pnlQuestionario.PerformLayout();
            this.pnlCarteiraInvestimentos.ResumeLayout(false);
            this.pnlCarteiraInvestimentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtClienteCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClienteEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlInformacoesCliente;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Button btnClienteEnviar;
        private System.Windows.Forms.MaskedTextBox txtClienteDtNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlQuestionario;
        private System.Windows.Forms.RadioButton rdnRespostaA;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.RadioButton rdnRespostaC;
        private System.Windows.Forms.RadioButton rdnRespostaB;
        private System.Windows.Forms.Button btnQuestaoAnterior;
        private System.Windows.Forms.Button btnProximaQuestao;
        private System.Windows.Forms.Label lblQuestaoAtual;
        private System.Windows.Forms.Panel pnlCarteiraInvestimentos;
        private System.Windows.Forms.Label lblPerfilInvestidorCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlItensCarteiraInvestimentos;
        private System.Windows.Forms.Button btnReenviarEmail;
    }
}

