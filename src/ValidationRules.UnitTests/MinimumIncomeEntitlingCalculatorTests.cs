using Xunit;

namespace RulesPattern.UnitTests
{
    public class MinimumIncomeEntitlingCalculatorTests
    {
        [Fact]
        public void ReturnFalse_WhenMonthlyIncomeIsGreaterThan780()
        {
            // Arrange
            Person person = GetTestPerson();
            person.MonthlyIncome = 800;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnFalse_WhenHouseholdIncomeIsGreaterThan9360()
        {
            // Arrange
            Person person = GetTestPerson();
            person.HouseholdIncome = 10000;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnFalse_WhenRealEstateValueIsGreaterThan30000()
        {
            // Arrange
            Person person = GetTestPerson();
            person.RealEstateValue = 31000;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnFalse_WhenMovablePropertyValueIsGreaterThan6000()
        {
            // Arrange
            Person person = GetTestPerson();
            person.MovablePropertyValue = 6100;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnFalse_WhenHasLivedAbroadTheLast2Years()
        {
            // Arrange
            Person person = GetTestPerson();
            person.HasLivedAbroadLast2Years = true;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnFalse_WhenCarEngineDisplacementIsGreaterThan1600()
        {
            // Arrange
            Person person = GetTestPerson();
            person.CarEngineDisplacement = 1800;

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.False(isEntitled);
        }

        [Fact]
        public void ReturnTrue_WhenMetRequirements()
        {
            // Arrange
            Person person = GetTestPerson();

            var calculator = new MinimumIncomeEntitlingCalculator();

            // Act
            bool isEntitled = calculator.CheckIfPersonIsEntitledToMinimumIncome(person);

            // Assert
            Assert.True(isEntitled);
        }

        private static Person GetTestPerson()
        {
            var person = new Person
            {
                MonthlyIncome = 700,
                CarEngineDisplacement = 1000,
                HouseholdIncome = 6000,
                MovablePropertyValue = 3000,
                RealEstateValue = 0,
                HasLivedAbroadLast2Years = false
            };

            return person;
        }
    }
}
