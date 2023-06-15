var employees = new List<Employee>
            {
                new Employee {LastName = "Ivanov", FirstName = "Ivan"},
                new Employee {LastName = "Andreev", FirstName = "Andrew"},
                new Employee {LastName = "Petrov", FirstName = "Petr"}
            };

var query = from emp in employees
            let fullName = emp.FirstName + " " + emp.LastName // let - lokal dəyişən yaratmaq üçün.
            orderby fullName descending
            select fullName;

foreach (var person in query)
    Console.WriteLine(person);

// Delay.
Console.ReadKey();

public class Employee
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
}