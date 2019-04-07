namespace ValidationRules
{
    public interface IEntitledRule
    {
        bool CheckIfEntitledToMinimumIncome(Person person);
    }
}