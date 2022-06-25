using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LetsInvest.Business
{
    public static class Email
    {
        #region Constantes

        private const string EMAIL = "letsinvest100@outlook.com";
        private const string NOME_DISPLAY = "Let's Invest";
        private const string SENHA = "!Letsinvest123";
        private const string SMTP = "smtp-mail.outlook.com";
        private const int PORTA_SMTP = 25;

        #endregion Constantes

        public static void EnviarEmail(Cliente cliente)
        {
            try
            {
                MailMessage mail = new MailMessage();

                SmtpClient SmtpServer = new SmtpClient(SMTP, PORTA_SMTP);

                mail.From = new MailAddress(EMAIL, NOME_DISPLAY);

                mail.To.Add(cliente.Email);

                mail.Subject = "Carteira de Investimentos";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;

                mail.IsBodyHtml = true;
                mail.Body = MontarCorpoEmail(cliente);

                mail.BodyEncoding = System.Text.Encoding.UTF8;

                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(EMAIL, SENHA);

                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }

            catch (SmtpException ex)
            {
                throw new SmtpException(ex.Message);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static string MontarCorpoEmail(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Olá, <strong>{cliente.Nome.Split(' ')[0]}!</strong>\n");
            sb.AppendLine($"Obrigado pela confiança. A sua satisfação é a nossa prioridade!");
            sb.AppendLine($"Segue as informações da carteira de investimentos que montamos especialmente para você:\n");
            sb.AppendLine($"Perfil de Investidor: <strong>{cliente.perfilInvestidor.ToString().Replace('_', ' ')}</strong>\n");
            sb.AppendLine($"{cliente.Carteira.ToString()}");
            sb.AppendLine($"\n");
            sb.AppendLine($"Ass,");
            sb.AppendLine($"Let's Invest.");

            return sb.ToString().Replace("\n", "<br />");
        }
    }
}
