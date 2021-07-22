using System;

namespace RulesEngine_NRules
{
    public class Customer
    {
        public string Name { get; }
        public bool IsPreferred { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void NotifyAboutDiscount()
        {
            Console.WriteLine($"Customer {Name} was notified about a discount");
        }
    }
}
