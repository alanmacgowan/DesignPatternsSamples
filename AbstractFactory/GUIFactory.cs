using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }
}
