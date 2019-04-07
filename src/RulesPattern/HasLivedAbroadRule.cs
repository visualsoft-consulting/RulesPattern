namespace RulesPattern
{
    public class HasLivedAbroadRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return !person.HasLivedAbroadLast2Years;
        }
    }
}