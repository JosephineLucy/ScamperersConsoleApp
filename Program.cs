using System;
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }

    public Employee(string name)
    {
        FirstName = name;
    }
}

public class OfficeManager
{
    public void WelcomeNewEmployee(List<Employee> newEmployees)
    {
        foreach (var employee in newEmployees)
        {
            Console.WriteLine($"Hello, {employee.FirstName}. Welcome to the company, you will have lots of fun here!");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        List<Employee> newEmployees = new List<Employee>
        {
            new Employee("Ross"),
            new Employee("Rachel"),
            new Employee("Monica"),
            new Employee("Phoebe"),
            new Employee("Joey"),
            new Employee("Chandler")
        };

        OfficeManager gunther = new OfficeManager();
        gunther.WelcomeNewEmployee(newEmployees);
    }
}
