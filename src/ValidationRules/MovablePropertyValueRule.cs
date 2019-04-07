namespace RulesPattern
{
    public class MovablePropertyValueRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.MovablePropertyValue < 6000;
        }
    }
}