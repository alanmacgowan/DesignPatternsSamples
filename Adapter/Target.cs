using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
