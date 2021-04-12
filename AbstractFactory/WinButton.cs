using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("This is a Windows Button");
        }
    }
}
