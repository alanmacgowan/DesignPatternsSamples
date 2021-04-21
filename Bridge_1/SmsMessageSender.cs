using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_1
{
    public class SmsMessageSender : IMessageSender
    {
        public void SendMessage(string Message)
        {
            Console.WriteLine("'" + Message + "'   : This Message has been sent using SMS");
        }
    }
}
