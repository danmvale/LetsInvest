using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public class InvestimentoRendaVariavel : Investimento
    {
        private decimal precoCota;

        public decimal PrecoCota { get => precoCota; set => precoCota = value; }

        public InvestimentoRendaVariavel(string nome, string descricao, List<Corretora> corretoras, ENivelRisco nivelRisco, decimal rentabilidade, decimal precoCota) : base(nome, descricao, corretoras, nivelRisco, rentabilidade)
        {
            this.PrecoCota = precoCota;
        }

        public override decimal SimularInvestimento(decimal valor, int periodo)
        {
            return base.SimularInvestimento(valor, periodo);
        }

        public override string ToString()
        {
            return base.ToString() + $"Preço por cota: R$ {this.PrecoCota:N2}.\n";
        }
    }
}
