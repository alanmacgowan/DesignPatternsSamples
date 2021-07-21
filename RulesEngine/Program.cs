using System;

namespace RulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer
            {
                DateOfBirth = DateTime.Today.AddYears(-18).AddDays(-1),
                DateOfFirstPurchase = DateTime.Today,
                IsVeteran = true
            };

            var _calculator = new DiscountCalculator();
            var discount = _calculator.CalculateDiscountPercentage(customer);

            Console.WriteLine($"Total Discount: {discount}");
        }
    }
}
