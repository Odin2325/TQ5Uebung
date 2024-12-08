using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.Simple
{
    internal class MessageWorker
    {

        public MessageWorker() { }

        public string CallBack(string message)
        {
            string msg = message.ToUpper();
            return msg;
        }
    }
}
