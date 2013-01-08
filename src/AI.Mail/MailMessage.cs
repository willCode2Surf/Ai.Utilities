using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class MailMessage
    {
        public MailMessage()
        {
            this.Attachments = new List<Attachment>();
        }

        public IList<string> SplitAddresses(string emails)
        {
            var list = emails.Split(new string[] {";"}, StringSplitOptions.RemoveEmptyEntries);
            return list;
        }

    
        

        public string From { get; set; }

        public string To { get; set; }

        public string Cc { get; set; }

        public string Bcc { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public bool IsBodyHtml { get; set; }

        public IList<Attachment> Attachments { get; set; } 
    }
}
