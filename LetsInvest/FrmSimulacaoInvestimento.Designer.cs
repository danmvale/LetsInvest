namespace LetsInvest
{
    partial class FrmSimulacaoInvestimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSimulacaoInvestimento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorInvestimento = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodoInvestimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvisoRendaVariavel = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // txtValorInvestimento
            // 
            this.txtValorInvestimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.txtValorInvestimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtValorInvestimento.Location = new System.Drawing.Point(16, 61);
            this.txtValorInvestimento.Margin = new System.Windows.Forms.Padding(20);
            this.txtValorInvestimento.Name = "txtValorInvestimento";
            this.txtValorInvestimento.Size = new System.Drawing.Size(150, 27);
            this.txtValorInvestimento.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(12, 206);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(302, 38);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label4.Location = new System.Drawing.Point(171, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "reais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label2.Location = new System.Drawing.Point(102, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "dias";
            // 
            // txtPeriodoInvestimento
            // 
            this.txtPeriodoInvestimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.txtPeriodoInvestimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPeriodoInvestimento.Location = new System.Drawing.Point(16, 121);
            this.txtPeriodoInvestimento.Margin = new System.Windows.Forms.Padding(20);
            this.txtPeriodoInvestimento.Name = "txtPeriodoInvestimento";
            this.txtPeriodoInvestimento.Size = new System.Drawing.Size(84, 27);
            this.txtPeriodoInvestimento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tempo";
            // 
            // lblAvisoRendaVariavel
            // 
            this.lblAvisoRendaVariavel.AutoSize = true;
            this.lblAvisoRendaVariavel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblAvisoRendaVariavel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.lblAvisoRendaVariavel.Location = new System.Drawing.Point(9, 9);
            this.lblAvisoRendaVariavel.Name = "lblAvisoRendaVariavel";
            this.lblAvisoRendaVariavel.Size = new System.Drawing.Size(312, 17);
            this.lblAvisoRendaVariavel.TabIndex = 12;
            this.lblAvisoRendaVariavel.Text = "*Retorno passado não é garantia de retorno futuro!";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 165);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(20, 21);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.Text = "=";
            // 
            // FrmSimulacaoInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(328, 256);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblAvisoRendaVariavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeriodoInvestimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorInvestimento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 295);
            this.MinimumSize = new System.Drawing.Size(344, 295);
            this.Name = "FrmSimulacaoInvestimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Let\'s Invest | Simulação Investimento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorInvestimento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodoInvestimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvisoRendaVariavel;
        private System.Windows.Forms.Label lblResultado;
    }
}