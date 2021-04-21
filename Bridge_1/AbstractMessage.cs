using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_1
{
    public abstract class AbstractMessage
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage(string Message);
    }
}
