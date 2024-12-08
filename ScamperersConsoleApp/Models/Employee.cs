namespace ScamperersConsoleApp.ScamperersConsoleApp.Models
{
    public class Employee
    {
        public string FirstName { get; set; }

        public Employee(string name)
        {
            FirstName = name;
        }
    }
}
