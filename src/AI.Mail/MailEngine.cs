using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class MailEngine
    {
        public MailEngine(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        private static MailEngine _instance = new MailEngine(_mailSender);
        private MailQueue _mailQueue = new MailQueue();
        private static IMailSender _mailSender;

        public static MailEngine Instance
        {
            get { return _instance; }
        }

        public void Add(MailMessage mail)
        {
            _mailQueue.Enqueue(mail);
        }

        protected virtual void Execute()
        {
            while(true)
            {
                var mail = _mailQueue.Dequeue();
                _mailSender.Send(mail);
                this.OnMailSent(mail);

            }
        }
        public event EventHandler<MailSentEventArgs> MailSent;

        protected virtual void OnMailSent(MailMessage mail)
        {
            if(MailSent != null)
                MailSent(this,new MailSentEventArgs(){Message = mail});
        }
    }
}
