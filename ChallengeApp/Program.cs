using ChallengeApp;

List<Employee> employees = new List<Employee>();

Employee employee1 = new Employee("Patryk", "Wisniewski", 26);
Employee employee2 = new Employee("Staszek", "Kolasa", 41);
Employee employee3 = new Employee("Grzegorz", "Brzęczyszczykiewicz", 45);

employee1.AddScore(9);
employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(1);

employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(6);

employee3.AddScore(4);
employee3.AddScore(7);
employee3.AddScore(8);
employee3.AddScore(4);
employee3.AddScore(6);

employees.Add(employee1);
employees.Add(employee2);
employees.Add(employee3);

int MaxResult = 0;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.Result > MaxResult)
    { MaxResult = employee.Result;
      employeeWithMaxResult = employee;      
    }
}
Console.WriteLine("Najwiecej punków zdobył");
Console.WriteLine(employeeWithMaxResult.Name + " " +  employeeWithMaxResult.Surname);
Console.WriteLine("Wiek" + employeeWithMaxResult.Age);
Console.WriteLine("z wynikiem" + employeeWithMaxResult.Result + "punktów");