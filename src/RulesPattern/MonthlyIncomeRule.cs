namespace RulesPattern
{
    public class MonthlyIncomeRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.MonthlyIncome < 780;
        }
    }
}