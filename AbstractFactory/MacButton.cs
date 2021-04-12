using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("This is a Mac Button");
        }
    }
}
