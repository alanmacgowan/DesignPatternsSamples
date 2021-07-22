using NRules.Fluent.Dsl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RulesEngine_NRules
{
    public class PreferredCustomerDiscountRule : Rule
    {
        public override void Define()
        {
            Customer customer = default;
            IEnumerable<Order> orders = default;

            When()
                .Match<Customer>(() => customer, c => c.IsPreferred)
                .Query(() => orders, x => x
                    .Match<Order>(
                        o => o.Customer == customer,
                        o => o.IsOpen,
                        o => o.PercentDiscount == 0.0)
                    .Collect()
                    .Where(c => c.Any()));

            Then()
                .Do(ctx => ApplyDiscount(orders, 10.0))
                .Do(ctx => ctx.UpdateAll(orders));
        }

        private static void ApplyDiscount(IEnumerable<Order> orders, double discount)
        {
            foreach (var order in orders)
            {
                order.PercentDiscount = discount;
            }
        }
    }
}
