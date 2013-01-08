using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public interface IMailSender
    {
        void Send(MailMessage mail);
    }
}
