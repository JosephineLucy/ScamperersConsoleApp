using ScamperersConsoleApp;
using System;
using System.Collections.Generic;

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
