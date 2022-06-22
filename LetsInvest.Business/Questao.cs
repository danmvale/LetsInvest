using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public class Questao
    {
        private string pergunta;
        private Dictionary<byte, string> alternativas;
        private byte resposta = 0;

        public string Pergunta { get => pergunta; set => pergunta = value; }
        public Dictionary<byte, string> Alternativas { get => alternativas; set => alternativas = value; }

        public byte Resposta
        {
            get => resposta;

            set
            {
                if (!Alternativas.ContainsKey(value))
                    throw new ArgumentOutOfRangeException("A resposta não é válida.", innerException: null);

                resposta = value;
            }
        }

        public Questao(string pergunta, Dictionary<byte, string> alternativas)
        {
            Pergunta = pergunta;
            Alternativas = alternativas;
        }
    }
}
