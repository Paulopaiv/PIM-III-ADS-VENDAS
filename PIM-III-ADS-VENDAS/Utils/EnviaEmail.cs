using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using PIM_III_ADS_VENDAS.Service;

namespace PIM_III_ADS_VENDAS.Utils
{
    public class EnviaEmail
    {
        public void EnviarEmail(string nome, string destinatario, string codigo, string formaDePagamento, string valorIngresso)
        {
            MailMessage message = new MailMessage();
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Timeout = 60 * 1000;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pim3ads@gmail.com", "q n a m n b c j e r x fa h r r");

                message.From = new MailAddress("pim3ads@gmail.com");

                message.Body = message.Body = message.Body = "<html>" +
               "<body>" +
               $"<h2 style=\"color: #333;\">Olá, {nome}!</h2>" +
               "<p>Obrigado por comprar seu ingresso para o museu!</p>" +
               $"<p>Seu código de visitante é: {codigo}</p>" +
               $"<p>Forma de pagamento: {formaDePagamento}</p>" +
               $"<p>Valor do ingresso: R${valorIngresso}</p>" +
               "<p>Tenha uma ótima visita!</p>" +
               "</body>" +
               "</html>";


                message.Subject = "Seu Código de Visitante";
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                message.To.Add(new MailAddress(destinatario));

                smtp.Send(message);
            }
            catch (Exception Erro)
            {

                MessageBox.Show("Erro ao enviar e-mail!");
            }
        }
    }
}
