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

namespace LetsInvest
{
    public partial class FrmSimulacaoInvestimento : Form
    {
        private Investimento investimento;

        public FrmSimulacaoInvestimento(Investimento investimento)
        {
            InitializeComponent();

            this.investimento = investimento;

            if (investimento.GetType() == typeof(InvestimentoRendaFixa))
                lblAvisoRendaVariavel.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = 0;
                int periodo = 0;

                if (!decimal.TryParse(txtValorInvestimento.Text, out valor))
                    MostrarErro("O valor digitado não é válido.");

                else
                {
                    if (!int.TryParse(txtPeriodoInvestimento.Text, out periodo))
                        MostrarErro("O período digitado não é válido.");

                    else
                        lblResultado.Text = "= R$ " + investimento.SimularInvestimento(valor, periodo).ToString("N2");
                }
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void MostrarErro(Exception ex)
        {
            string mensagem = "";

            mensagem += ex.Message;

            //mensagem += "Tipo do Erro: " + ex.GetType();
            //mensagem += "\nMensagem: " + ex.Message;
            //mensagem += "\nLocal: " + ex.StackTrace;

            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MostrarErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
