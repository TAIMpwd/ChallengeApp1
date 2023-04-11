namespace ChallengeApp
{
    public class Employee
    {

        private List<int> Score = new List<int>();

        public Employee(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public Employee(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.Score.Sum();
            }

        }

        public string V1 { get; }
        public string V2 { get; }

        public void AddScore(int number)
        {
            this.Score.Add(number);
        }
    }
}
