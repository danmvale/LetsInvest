using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LetsInvest.Business;

namespace LetsInvest.Controls
{
    public partial class UcInvestimento : UserControl
    {
        private Investimento investimento;

        public UcInvestimento(Investimento investimento)
        {
            InitializeComponent();

            if (investimento != null)
            {
                this.investimento = investimento;
                MostrarInformacoes();
            }
        }

        private void MostrarInformacoes()
        {
            txtNome.Text = investimento.Nome;
            txtDescricao.Text = investimento.Descricao;
            lblNivelRisco.Text = investimento.NivelRisco.ToString().Replace("_", " ");
            lblRentabilidade.Text = (investimento.Rentabilidade * 100).ToString("N2") + "%";

            if (investimento.GetType() == typeof(InvestimentoRendaFixa))
            {
                lblTipoRenda.Text = "Renda Fixa";

                lblPrecoCota.Text = "-";
                lblPrazoMinimoRetirada.Text = ((InvestimentoRendaFixa)investimento).PrazoMinimoRetirada.ToString() + " dias";
            }

            else if (investimento.GetType() == typeof(InvestimentoRendaVariavel))
            {
                lblTipoRenda.Text = "Renda Variável";

                lblPrazoMinimoRetirada.Text = "-";
                lblPrecoCota.Text = "R$ " + ((InvestimentoRendaVariavel)investimento).PrecoCota.ToString("N2");
            }

            MostrarCorretoras();
        }

        public void MostrarCorretoras()
        {
            int yAtual = 0;
            Font font = new Font(lblCorretoraModelo.Font, FontStyle.Bold | FontStyle.Underline);

            pnlCorretoras.Controls.Clear();

            for (int i = 0; i < investimento.Corretoras.Count; i++)
            {
                Label lbl = new Label();

                lbl.Text = investimento.Corretoras[i].Nome;
                lbl.Name = "lblCorretora" + i;
                lbl.Font = font;
                lbl.ForeColor = Color.SkyBlue;
                lbl.Cursor = Cursors.Hand;
                lbl.Click += new System.EventHandler(lblCorretora_Click);

                ttp.SetToolTip(lbl, investimento.Corretoras[i].Nome + "\nTaxa de administração: " + (investimento.Corretoras[i].TaxaAdministracao * 100).ToString("N2") + "%");

                lbl.Parent = pnlCorretoras;

                lbl.Location = new Point(0, yAtual);

                yAtual += lbl.Height;
            }
        }

        private void btnSimularInvestimento_Click(object sender, EventArgs e)
        {
            FrmSimulacaoInvestimento frmSimulacaoInvestimento = new FrmSimulacaoInvestimento(investimento);

            frmSimulacaoInvestimento.ShowDialog();
        }

        private void lblCorretora_Click(object sender, EventArgs e)
        {
            string link = investimento.Corretoras[int.Parse(((Control)sender).Name.Replace("lblCorretora", ""))].Link;

            System.Diagnostics.Process.Start(link);
        }
    }
}
