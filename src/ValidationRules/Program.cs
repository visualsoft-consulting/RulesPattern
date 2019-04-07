using System;

namespace ValidationRules
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person
            {
                MonthlyIncome = 400,
                CarEngineDisplacement = 1000,
                HouseholdIncome = 6000,
                MovablePropertyValue = 3000,
                RealEstateValue = 0,
                HasLivedAbroad2Years = false
            };

            var calculator = new MinimumIncomeEntitlingCalculator();
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            Console.WriteLine($"Is entitled? {isEntitled}");
        }
    }
}