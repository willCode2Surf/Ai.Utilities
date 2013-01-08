using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class MailSender : IMailSender
    {
        public void Send(MailMessage mail)
        {
            using(var client = new System.Net.Mail.SmtpClient())
            {
                client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["UserName"],
                                                           ConfigurationManager.AppSettings["Password"]);
                client.Host = ConfigurationManager.AppSettings["SMTPHost"];

                var message = new System.Net.Mail.MailMessage();
                foreach (var email in mail.SplitAddresses(mail.Bcc))
                    message.Bcc.Add(new MailAddress(email));
                foreach(var email in mail.SplitAddresses(mail.Cc))
                    message.CC.Add(new MailAddress(email));
                foreach(var email in mail.SplitAddresses(mail.To))
                    message.To.Add(new MailAddress(email));
                message.From = new MailAddress(mail.From);
                message.IsBodyHtml = mail.IsBodyHtml;
                message.Body = mail.Body;
                message.Subject = mail.Subject;
                foreach(var attachment in mail.Attachments)
                {
                    message.Attachments.Add(new System.Net.Mail.Attachment(new MemoryStream(attachment.Data),attachment.Type));
                }
                client.Send(message);

            }
        }
    }
}
