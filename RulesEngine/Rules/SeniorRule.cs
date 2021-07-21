using System;

namespace RulesEngine
{
    public class SeniorRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.DateOfBirth < DateTime.Now.AddYears(-65))
            {
                return .05m;
            }
            return 0;
        }
    }
}
