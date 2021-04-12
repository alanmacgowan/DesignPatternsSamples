using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MacCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("This is a Mac Checkbox");
        }
    }
}
