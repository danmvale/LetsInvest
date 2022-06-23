using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public class Carteira
    {
        private string descricao;
        private List<Investimento> investimentos;

        public string Descricao { get => descricao; set => descricao = value; }
        public List<Investimento> Investimentos { get => investimentos; set => investimentos = value; }

        public Carteira(string descricao)
        {
            Descricao = descricao;
            investimentos = new List<Investimento>();
        }

        public override string ToString()
        {
            string info = "";

            foreach (var investimento in Investimentos)
                info += investimento.ToString() + "\n";

            return info;
        }

        public static Carteira MontarCarteira(Cliente cliente)
        {
            Carteira carteira = null;

            Corretora corretora1 = new Corretora("Caixa", 0.004m, "www.caixa.gov.br");
            Corretora corretora2 = new Corretora("Safra", 0m, "www.safra.com.br/");
            Corretora corretora3 = new Corretora("XP Investimentos", .003m, "www.xpi.com.br/");
            Corretora corretora4 = new Corretora("Coinext", .001m, "www.coinext.com.br");

            if (cliente.perfilInvestidor == EPerfilInvestidor.ULTRA_CONSERVADOR)
            {
                carteira = new Carteira("Essa carteira é ideal para aqueles que não desejam correr nenhum risco e não almejam rendimentos extravagantes a longo prazo.");

                carteira.Investimentos.Add(new InvestimentoRendaFixa("Poupança", "Poupança (renda fixa)", new List<Corretora> { corretora1 }, ENivelRisco.MUITO_BAIXO, .0617m, 30));
            }

            else if (cliente.perfilInvestidor == EPerfilInvestidor.CONSERVADOR)
            {
                carteira = new Carteira("");

                carteira.Investimentos.Add(new InvestimentoRendaFixa("CDB", "Certificado de depósito bancário (renda fixa)", new List<Corretora> { corretora1, corretora2, corretora3 }, ENivelRisco.BAIXO, .1315m, 1));
                carteira.Investimentos.Add(new InvestimentoRendaFixa("LCI", "Letra de crédito imobiliário (renda fixa)", new List<Corretora> { corretora1, corretora2, corretora3 }, ENivelRisco.BAIXO, .1184m, 90));
                carteira.Investimentos.Add(new InvestimentoRendaFixa("Tesouro Selic", "Tesouro Direto vinculado à taxa Selic (renda fixa)", new List<Corretora> { corretora1, corretora2, corretora3 }, ENivelRisco.BAIXO, .1325m, 1080));
            }

            else if (cliente.perfilInvestidor == EPerfilInvestidor.MODERADO)
            {
                decimal IPCA = 10.06m / 100m;

                carteira = new Carteira("");

                carteira.Investimentos.Add(new InvestimentoRendaVariavel("ETF", "Fundo de índice (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.MÉDIO, .2248m, 98.44m));
                carteira.Investimentos.Add(new InvestimentoRendaVariavel("FII", "Fundo de investimento imobiliário (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.MÉDIO, .078m, 92.48m));
                carteira.Investimentos.Add(new InvestimentoRendaFixa("Tesouro IPCA+", "Tesouro Direto vinculado à inflação + taxa fixa (renda fixa)", new List<Corretora> { corretora1, corretora2, corretora3 }, ENivelRisco.MÉDIO, IPCA + .0536m, 1440));
            }

            else if (cliente.perfilInvestidor == EPerfilInvestidor.ARROJADO)
            {
                carteira = new Carteira("");

                carteira.Investimentos.Add(new InvestimentoRendaVariavel("IBMB34", "Ações da International Business Machines (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.ALTO, .0585m, 694.83m));
                carteira.Investimentos.Add(new InvestimentoRendaVariavel("GOGL34", "Ações da Google (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.ALTO, .1002m, 73.27m));
                carteira.Investimentos.Add(new InvestimentoRendaVariavel("ABEV3", "Ações da Ambev (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.ALTO, .2990m, 13.13m));
            }

            else if (cliente.perfilInvestidor == EPerfilInvestidor.ULTRA_ARROJADO)
            {
                carteira = new Carteira("");

                carteira.Investimentos.Add(new InvestimentoRendaVariavel("MSFT34", "Ações da Microsoft (renda variável)", new List<Corretora> { corretora2, corretora3 }, ENivelRisco.ALTO, .0585m, 694.83m));
                carteira.Investimentos.Add(new InvestimentoRendaVariavel("Bitcoin", "Criptomoeda (renda variável)", new List<Corretora> { corretora4 }, ENivelRisco.MUITO_ALTO, .3285m, 106424.86m));
                carteira.Investimentos.Add(new InvestimentoRendaVariavel("Ethereum", "Criptomoeda (renda variável)", new List<Corretora> { corretora4 }, ENivelRisco.MUITO_ALTO, .3864m, 5801.89m));
            }

            return carteira;
        }
    }
}
