﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WinCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("This is a Windows Checkbox");
        }
    }
}
