namespace ScamperersConsoleApp.ScamperersConsoleApp.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public Employee(string firstName)
        {
            FirstName = firstName;
        }
    }
}
