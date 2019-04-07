namespace RulesPattern.Rules
{
    public interface IEntitledRule
    {
        bool CheckIfEntitledToMinimumIncome(Person person);
    }
}