using ScamperersConsoleApp.ScamperersConsoleApp.Models;

public class Program
{
    public static void Main(string[] args)
    {

        List<Employee> newEmployees = new List<Employee>
        {
            new Employee("Ross"), // should be Todd1
            new Employee("Rachel"), // should be Todd2
            new Employee("Monica"), // should be Todd3
            new Employee("Phoebe"), // should be Todd4
            new Employee("Joey"), // should be Todd5
            new Employee("Chandler") // should be Todd6
        };

        OfficeManager todd = new OfficeManager();
        todd.WelcomeNewEmployee(newEmployees);
    }
}
