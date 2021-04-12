﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
