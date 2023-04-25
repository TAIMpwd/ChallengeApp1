using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatisticsCalled_ShouldRetournCorrectMax()
        {
            //Arrange
            var employee = new Employee("Patryk", "Wisniewski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //Act
            var statistics = employee.GetStatistic();

            //Assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRetournCorrectMin()
        {
            //Arrange
            var employee = new Employee("Patryk", "Wisniewski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //Act
            var statistics = employee.GetStatistic();

            //Assert
            Assert.AreEqual(2, statistics.Min);

        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldRetournCorrectAverage()
        {
            //Arrange
            var employee = new Employee("Patryk", "Wisniewski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //Act
            var statistics = employee.GetStatistic();

            //Assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Avarage, 2));

        }

    }
}
