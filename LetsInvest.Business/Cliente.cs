using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public enum EPerfilInvestidor
    {
        ULTRA_CONSERVADOR,
        CONSERVADOR,
        MODERADO,
        ARROJADO,
        ULTRA_ARROJADO
    }

    public class Cliente
    {
        private string nome;
        private string cpf;
        private DateTime dataNascimento;
        private string email;
        private Carteira carteira;
        public EPerfilInvestidor perfilInvestidor;

        public string Nome
        {
            get => nome;

            set
            {
                const string NOME_INVALIDO = "O nome digitado não é válido.";

                if (string.IsNullOrEmpty(value.Trim()))
                    throw new ArgumentNullException(NOME_INVALIDO, innerException: null);

                foreach (var c in value)
                {
                    if (!(char.IsLetter(c) || char.IsWhiteSpace(c)))
                        throw new ArgumentNullException(NOME_INVALIDO, innerException: null);
                }

                nome = value;
            }
        }

        public string Cpf
        {
            get => cpf;

            set
            {
                const string CPF_INVALIDO = "O CPF digitado não é válido.";

                if (!long.TryParse(value, out long result) || value.Length != 11)
                    throw new ArgumentNullException(CPF_INVALIDO, innerException: null);

                cpf = value;
            }
        }

        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        public string Email
        {
            get => email;

            set
            {
                const string EMAIL_INVALIDO = "O email digitado não é válido.";

                if (string.IsNullOrEmpty(value.Trim()) || value.Trim().Length < 5 || !value.Contains("@"))
                    throw new ArgumentNullException(EMAIL_INVALIDO, innerException: null);

                email = value;
            }
        }

        public Carteira Carteira { get => carteira; set => carteira = value; }

        public Cliente(string nome, string cpf, DateTime dataNascimento, string email)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Email = email;
        }

        public void ObterPerfilInvestidor(List<Questao> questoes)
        {
            decimal soma = 0;

            for (int i = 0; i < questoes.Count; i++)
                soma += questoes[i].Resposta;

            decimal media = soma / (decimal)questoes.Count;

            if (media == 1)
                this.perfilInvestidor = EPerfilInvestidor.ULTRA_CONSERVADOR;
            else if (media <= 1.5m)
                this.perfilInvestidor = EPerfilInvestidor.CONSERVADOR;
            else if (media <= 2)
                this.perfilInvestidor = EPerfilInvestidor.MODERADO;
            else if (media <= 2.5m)
                this.perfilInvestidor = EPerfilInvestidor.ARROJADO;
            else
                this.perfilInvestidor = EPerfilInvestidor.ULTRA_ARROJADO;
        }
    }
}
