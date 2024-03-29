﻿namespace RulesPattern.Rules
{
    public class RealEstateValueRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.RealEstateValue < 30000;
        }
    }
}