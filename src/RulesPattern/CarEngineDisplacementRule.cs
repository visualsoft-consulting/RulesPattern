namespace RulesPattern
{
    public class CarEngineDisplacementRule : IEntitledRule
    {
        public bool CheckIfEntitledToMinimumIncome(Person person)
        {
            return person.CarEngineDisplacement < 1600;
        }
    }
}