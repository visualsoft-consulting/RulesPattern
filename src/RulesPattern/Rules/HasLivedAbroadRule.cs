namespace RulesPattern.Rules
{
    public class HasLivedAbroadRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return !person.HasLivedAbroadLast2Years;
        }
    }
}