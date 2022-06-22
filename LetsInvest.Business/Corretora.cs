using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public class Corretora
    {
        private string nome;
        private decimal taxaAdministracao;
        private string link;

        public string Nome { get => nome; set => nome = value; }
        public decimal TaxaAdministracao { get => taxaAdministracao; set => taxaAdministracao = value; }
        public string Link { get => link; set => link = value; }

        public Corretora(string nome, decimal taxaAdministracao, string link)
        {
            this.Nome = nome;
            this.TaxaAdministracao = taxaAdministracao;
            this.Link = link;
        }
    }
}
