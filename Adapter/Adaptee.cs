using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
