using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("This is a Mac Checkbox");
        }
    }
}
