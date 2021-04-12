using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
