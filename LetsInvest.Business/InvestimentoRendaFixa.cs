using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public class InvestimentoRendaFixa : Investimento
    {
        private int prazoMinimoRetirada;

        public int PrazoMinimoRetirada { get => prazoMinimoRetirada; set => prazoMinimoRetirada = value; }

        public InvestimentoRendaFixa(string nome, string descricao, List<Corretora> corretoras, ENivelRisco nivelRisco, decimal rentabilidade, int prazoMinimoRetirada) : base(nome, descricao, corretoras, nivelRisco, rentabilidade)
        {
            this.PrazoMinimoRetirada = prazoMinimoRetirada;
        }

        public override decimal SimularInvestimento(decimal valorPrincipal, int periodo)
        {
            if (periodo < prazoMinimoRetirada)
                throw new ArgumentOutOfRangeException($"O período digitado deve ser maior ou igual a {prazoMinimoRetirada}", innerException: null);

            return base.SimularInvestimento(valorPrincipal, periodo);
        }

        public override string ToString()
        {
            return base.ToString() + $"Resgate: {this.PrazoMinimoRetirada} dias.\n";
        }
    }
}
