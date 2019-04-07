﻿namespace ValidationRules
{
    public class HouseholdIncomeRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.HouseholdIncome < 9360;
        }
    }
}