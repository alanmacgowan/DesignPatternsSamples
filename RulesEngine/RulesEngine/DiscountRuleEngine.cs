using System;
using System.Collections.Generic;

namespace RulesEngine
{
    public class DiscountRuleEngine
    {
        List<IDiscountRule> _rules = new List<IDiscountRule>();

        public DiscountRuleEngine(IEnumerable<IDiscountRule> rules)
        {
            _rules.AddRange(rules);
        }

        public decimal CalculateDiscountPercentage(Customer customer)
        {
            decimal discount = 0m;
            foreach (var rule in _rules)
            {
                discount = Math.Max(discount, rule.CalculateDiscount(customer, discount));
            }
            return discount;
        }
    }
}
