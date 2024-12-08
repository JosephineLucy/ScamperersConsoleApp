﻿namespace ScamperersConsoleApp.ScamperersConsoleApp.Models
{
    public class OfficeManager
    {
        internal void WelcomeNewEmployee(List<Employee> newEmployees)
        {
            foreach (var employee in newEmployees)
            {
                Console.WriteLine($"Hello, {employee.FirstName}. Welcome to the company, you will have lots of fun here!");
            }
        }
    }

}