using System;

namespace RulesEngine
{
    public class VeteranRule : IDiscountRule
    {
        public decimal CalculateDiscount(Customer customer, decimal currentDiscount)
        {
            if (customer.IsVeteran)
            {
                return .10m;
            }
            return 0;
        }
    }
}
