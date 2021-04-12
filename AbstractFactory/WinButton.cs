using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("This is a Windows Button");
        }
    }
}
