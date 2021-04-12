using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
