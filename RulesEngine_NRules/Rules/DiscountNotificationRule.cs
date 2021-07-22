using NRules.Fluent.Dsl;
using System;

namespace RulesEngine_NRules
{
    public class DiscountNotificationRule : Rule
    {
        public override void Define()
        {
            Customer customer = default;

            When()
                .Match<Customer>(() => customer)
                .Exists<Order>(o => o.Customer == customer, o => o.PercentDiscount > 0.0);

            Then()
                .Do(_ => customer.NotifyAboutDiscount());
        }
    }
}
