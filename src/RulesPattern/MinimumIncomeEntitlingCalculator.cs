using System.Collections.Generic;

namespace RulesPattern
{
    public class MinimumIncomeEntitlingCalculator
    {
        private readonly List<IEntitledRule> _rules = new List<IEntitledRule>();

        public MinimumIncomeEntitlingCalculator()
        {
            _rules.Add(new MonthlyIncomeRule());
            _rules.Add(new HouseholdIncomeRule());
            _rules.Add(new RealEstateValueRule());
            _rules.Add(new MovablePropertyValueRule());
            _rules.Add(new HasLivedAbroadRule());
            _rules.Add(new CarEngineDisplacementRule());
        }

        public bool CheckIfPersonIsEntitledToMinimumIncome(Person person)
        {
            var isEntitled = true;

            foreach (var rule in _rules)
            {
                isEntitled = rule.CheckIfEntitledToMinimumIncome(person);
                if (!isEntitled)
                {
                    break;
                }
            }

            return isEntitled;
        }
    }
}