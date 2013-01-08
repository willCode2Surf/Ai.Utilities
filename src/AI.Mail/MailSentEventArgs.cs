using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class MailSentEventArgs : EventArgs 
    {
        public MailMessage Message { get; set; }
    }
}
