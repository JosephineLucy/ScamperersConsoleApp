﻿using ScamperersConsoleApp;

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

        OfficeManager todd = new OfficeManager();
        todd.WelcomeNewEmployee(newEmployees);
    }
}
