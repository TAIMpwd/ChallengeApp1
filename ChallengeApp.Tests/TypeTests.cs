namespace ChallengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void IfNumbersAreEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 1;

            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void EmployeeNameAreTheSame()
        {
            //arrange
            var Employee1 = GetUser("Patryk");
            var Employee2 = GetUser("Patryk");
            //act


            //assert
            Assert.AreEqual(Employee1.Login, Employee2.Login);


        }
        private User GetUser(string name)
        {
            return new User(name);
        }

        internal class User
        {
            internal object? Login;
            private string name;

            public User(string name)
            {
                this.name = name;
            }
        }
    }
}