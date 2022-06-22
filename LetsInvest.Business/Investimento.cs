using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public enum ENivelRisco
    {
        MUITO_BAIXO,
        BAIXO,
        MÉDIO,
        ALTO,
        MUITO_ALTO
    }

    public class Investimento
    {
        private string nome;
        private string descricao;
        private List<Corretora> corretoras;
        private decimal rentabilidade;
        private ENivelRisco nivelRisco;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public List<Corretora> Corretoras { get => corretoras; set => corretoras = value; }
        public decimal Rentabilidade { get => rentabilidade; set => rentabilidade = value; }
        public ENivelRisco NivelRisco { get => nivelRisco; set => nivelRisco = value; }

        public Investimento(string nome, string descricao, List<Corretora> corretoras, ENivelRisco nivelRisco, decimal rentabilidade)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Corretoras = corretoras;
            this.nivelRisco = nivelRisco;
            this.Rentabilidade = rentabilidade;
        }

        public virtual decimal SimularInvestimento(decimal valor, int periodo)
        {
            double jurosAoDia = Math.Pow((double)(Rentabilidade + 1), 1.0 / 360.0);

            return valor * (decimal)Math.Pow(jurosAoDia, (double)periodo);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nome: {nome}.");
            sb.AppendLine($"Descrição: {descricao}.");
            sb.AppendLine("Corretoras:");

            for (int i = 0; i < corretoras?.Count; i++)
            {
                sb.AppendLine(corretoras[i].Nome?.ToString() + ", taxa de administração a.a.: "
                    + (corretoras[i].TaxaAdministracao * 100).ToString("0.00") + "%.");
            }

            sb.AppendLine($"Nível de Risco: {nivelRisco.ToString().Replace("_", " ")}.");
            sb.AppendLine($"Rentabilidade a.a. (RF) ou nos últimos 12 meses (RV): {(rentabilidade * 100).ToString("N2")}%.");

            return sb.ToString();
        }
    }
}
