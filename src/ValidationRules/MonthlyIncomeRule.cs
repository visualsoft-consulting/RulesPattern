namespace ValidationRules
{
    public class MonthlyIncomeRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.MonthlyIncome < 780;
        }
    }
}