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
using LetsInvest.Controls;

namespace LetsInvest
{
    public partial class FrmMain : Form
    {
        #region Propripedades

        private List<Questao> questionario = new List<Questao>();
        private byte questaoAtual = 0;

        private Cliente cliente = null;

        #endregion Propripedades

        #region Construtor

        public FrmMain()
        {
            InitializeComponent();
            Iniciar();
        }

        #endregion Construtor

        #region Eventos

        private void btnClienteEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                IniciarCliente();
                MostrarQuestionario();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClienteEnviar_Click(null, EventArgs.Empty);
                }
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void btnProximaQuestao_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarProximaQuestao();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void btnQuestaoAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarQuestaoAnterior();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void rdnRespostaA_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarRespostaQuestaoAtual();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void rdnRespostaB_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarRespostaQuestaoAtual();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void rdnRespostaC_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizarRespostaQuestaoAtual();
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        private void btnReenviarEmail_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() => Email.EnviarEmail(cliente));
            }

            catch (Exception ex)
            {
                MostrarErro(ex);
            }
        }

        #endregion Eventos

        #region Metodos

        private void Iniciar()
        {
            CarregarQuestionario();
        }

        private void IniciarCliente()
        {
            cliente = new Cliente(txtClienteNome.Text, txtClienteCPF.Text.Replace(".", "").Replace("-", ""), DateTime.Parse(txtClienteDtNascimento.Text), txtClienteEmail.Text);
        }

        private void MostrarCarteiraCliente()
        {
            const int MARGEM = 10;

            int largura = 0;
            int altura = 0;
            int xAtual = 0;
            int yAtual = 0;

            using (var ucInvestimento = new UcInvestimento(null))
            {
                largura = ucInvestimento.Width;
                altura = ucInvestimento.Height;
            }

            foreach (var investimento in cliente.Carteira.Investimentos)
            {
                pnlItensCarteiraInvestimentos.Controls.Add(new UcInvestimento(investimento) { Location = new Point(xAtual, yAtual) });

                xAtual += largura + MARGEM;
            }

            lblNomeCliente.Text = cliente.Nome.Split(' ')[0] + ",";
            lblPerfilInvestidorCliente.Text = cliente.perfilInvestidor.ToString().Replace("_", " ");

            Task.Run(() => Email.EnviarEmail(cliente));
        }

        private void CarregarQuestionario()
        {
            Dictionary<byte, string> alt1 = new Dictionary<byte, string>
            {
               {1, "Não conheço ou conheço pouco as regras do mercado financeiro e de capitais e\r\n preciso de orientação."},
               {2, "Tenho alguma experiência com investimentos, conheço razoavelmente as regras do\r\n mercado financeiro e de capitais, mas prefiro ter orientação."},
               {3, "Tenho formação acadêmica e/ou experiência na área de investimentos e me sinto\r\n seguro em tomar minhas decisões de investimento."}
            };

            Dictionary<byte, string> alt2 = new Dictionary<byte, string>
            {
               {1, "Quero preservar meu patrimônio, sem risco de perdas."},
               {2, "Desejo obter retornos moderados, ciente de que, para isso, preciso expor uma \r\nparcela do meu patrimônio a maior risco."},
               {3, "Minha prioridade é obter altos retornos, mesmo que isso signifique a \r\npossibilidade de perdas expressivas."}
            };

            Dictionary<byte, string> alt3 = new Dictionary<byte, string>
            {
               {1, "Ainda não possuo patrimônio financeiro relevante."},
               {2, "Já construí meu patrimônio, quero apenas mantê-lo."},
               {3, "Já iniciei a construção do meu patrimônio e pretendo aumentá-lo."}
            };

            Dictionary<byte, string> alt4 = new Dictionary<byte, string>
            {
               {1, "Até 1 ano."},
               {2, "Ate 5 anos."},
               {3, "Por mais de 5 anos."}
            };

            Dictionary<byte, string> alt5 = new Dictionary<byte, string>
            {
               {1, "Mais de 50%."},
               {2, "Até 50%."},
               {3, "Não tenho expectativa de resgatar recursos nos próximos 12 meses."}
            };

            Dictionary<byte, string> alt6 = new Dictionary<byte, string>
            {
               {1, "Nenhum ou produtos de renda fixa."},
               {2, "Produtos de renda fixa e produtos de renda variável."},
               {3, "Majoritariamente produtos de renda variável."}
            };

            Dictionary<byte, string> alt7 = new Dictionary<byte, string>
            {
               {1, "Nenhum ou produtos de renda fixa."},
               {2, "Produtos de renda fixa e produtos de renda variável."},
               {3, "Majoritariamente produtos de renda variável."}
            };

            questionario = new List<Questao>
            {
                new Questao("Qual frase melhor representa sua formação e/ou experiência profissional no mercado \r\nfinanceiro?", alt1),
                new Questao("Qual frase melhor representa seus objetivos e expectativas ao investir?", alt2),
                new Questao("Qual frase melhor representa seu momento atual como investidor?", alt3),
                new Questao("Por quanto tempo pretende manter seus recursos investidos?", alt4),
                new Questao("Qual percentual dos seus recursos você espera resgatar nos próximos 12 meses?", alt5),
                new Questao("Com quais produtos abaixo você tem familiaridade e/ou costuma investir com frequência?", alt6),
                new Questao("Em quais dos produtos abaixo você investe e/ou investiu mais de 10% de sua renda nos \r\núltimos 12 meses?", alt7)
            };
        }

        private void MostrarQuestionario()
        {
            ExibirQuestaoAtual();

            pnlInformacoesCliente.Visible = false;
            pnlQuestionario.Visible = true;
        }

        private void ExibirQuestaoAtual()
        {
            byte resp = questionario[questaoAtual].Resposta;

            var respostaRdn = new Dictionary<byte, RadioButton>
            {
                { 1, rdnRespostaA },
                { 2, rdnRespostaB },
                { 3, rdnRespostaC },
            };

            lblPergunta.Text = questionario[questaoAtual].Pergunta;

            rdnRespostaA.Text = questionario[questaoAtual].Alternativas[1];
            rdnRespostaB.Text = questionario[questaoAtual].Alternativas[2];
            rdnRespostaC.Text = questionario[questaoAtual].Alternativas[3];

            if (resp == 0)
                rdnRespostaA.Checked =
                rdnRespostaB.Checked =
                rdnRespostaC.Checked = false;

            else
                respostaRdn[resp].Checked = true;

            lblQuestaoAtual.Text = questaoAtual + 1 + " / " + questionario.Count;
        }

        private void MostrarProximaQuestao(bool automatico = false)
        {
            btnQuestaoAnterior.Visible = true;

            if (!automatico && questaoAtual == questionario.Count - 1)
            {
                FinalizarQuestionario();
                return;
            }

            questaoAtual++;
            ExibirQuestaoAtual();

            if (questaoAtual == questionario.Count - 1)
                btnProximaQuestao.Text = "Finalizar";
        }

        private void MostrarQuestaoAnterior()
        {
            btnProximaQuestao.Text = "Próxima";

            questaoAtual--;
            ExibirQuestaoAtual();

            if (questaoAtual == 0)
                btnQuestaoAnterior.Visible = false;
        }

        private void AtualizarRespostaQuestaoAtual()
        {
            if (rdnRespostaA.Checked)
            {
                questionario[questaoAtual].Resposta = 1;
                //MostrarProximaQuestao(true);

            }

            else if (rdnRespostaB.Checked)
            {
                questionario[questaoAtual].Resposta = 2;
                //MostrarProximaQuestao(true);
            }

            else if (rdnRespostaC.Checked)
            {
                questionario[questaoAtual].Resposta = 3;
                //MostrarProximaQuestao(true);
            }
        }

        private void FinalizarQuestionario()
        {
            bool questionarioValido = true;

            foreach (var questao in questionario)
            {
                if (questao.Resposta == 0)
                {
                    questionarioValido = false;
                    break;
                }
            }

            if (!questionarioValido)
            {
                MessageBox.Show("Você precisa responder todas as questões antes de enviar o questionário.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                cliente.ObterPerfilInvestidor(questionario);
                cliente.Carteira = Carteira.MontarCarteira(cliente);

                pnlQuestionario.Visible = false;
                pnlCarteiraInvestimentos.Visible = true;

                MostrarCarteiraCliente();
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

        #endregion Metodos
    }
}
