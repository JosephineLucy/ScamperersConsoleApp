namespace ScamperersConsoleApp.ScamperersConsoleApp.Models
{
    public class OfficeManager
    {
        public void InterviewCandidate()
        {
            Console.WriteLine("Enter the candidate name you would like to interview:");
            string candidateName = Console.ReadLine();
            Console.WriteLine($"You have chosen to interview {candidateName}");
        }
        public void WelcomeNewEmployee(List<Employee> newEmployees)
        {
            foreach (var employee in newEmployees)
            {
                Console.WriteLine($"Hello, {employee.FirstName}. Welcome to the company, you will have lots of fun here!");
            }
        }
    }

}
