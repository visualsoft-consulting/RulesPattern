namespace RulesPattern
{
    public interface IEntitledRule
    {
        bool CheckIfEntitledToMinimumIncome(Person person);
    }
}