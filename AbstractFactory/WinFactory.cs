using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
}
