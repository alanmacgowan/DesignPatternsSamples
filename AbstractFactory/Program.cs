using System;

namespace AbstractFactory
{
    class Program
    {

        static void Main(string[] args)
        {
            var _factory = GetFactory(OSType.Windows);

            var button = _factory.CreateButton();
            button.Paint();
            var checkBox = _factory.CreateCheckbox();
            checkBox.Paint();

        }

        private static IGUIFactory GetFactory(OSType osType)
        {
            switch (osType)
            {
                case OSType.Windows:
                    return new WinFactory();
                case OSType.Mac:
                    return new MacFactory();
                default:
                    return null;
            }
        }

        public enum OSType
        {
            Windows,
            Mac
        }
    }
}
