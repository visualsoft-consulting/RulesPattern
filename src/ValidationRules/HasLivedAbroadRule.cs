namespace ValidationRules
{
    public class HasLivedAbroadRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return !person.HasLivedAbroad2Years;
        }
    }
}