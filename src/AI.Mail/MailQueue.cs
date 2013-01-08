using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class MailQueue  : Queue<MailMessage>
    {
        private Queue<MailMessage> queue = new Queue<MailMessage>();

      


        public override string ToString()
        {
            return queue.ToString();
        }

      

        public override bool Equals(object obj)
        {
            return queue.Equals(obj);
        }

      
        public override int GetHashCode()
        {
            return queue.GetHashCode();
        }

     

    }
}
