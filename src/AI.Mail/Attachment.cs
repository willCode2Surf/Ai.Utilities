using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.Mail
{
    public class Attachment
    {
        public byte[] Data { get; set; }

        public System.Net.Mime.ContentType Type { get; set; }
    }
}
