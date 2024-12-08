using ScamperersConsoleApp.ScamperersConsoleApp.Models;

public class Program
{
    public static void Main(string[] args)
    {

        List<Candidate> hopefulCandidates = new List<Candidate>
        {
            new Candidate("Ross"),
            new Candidate("Rachel"),
            new Candidate("Monica"),
            new Candidate("Phoebe"),
            new Candidate("Joey"),
            new Candidate("Chandler"),
            new Candidate("Carol"),
            new Candidate("Paolo"),
            new Candidate("Janice")
        };

        OfficeManager todd = new OfficeManager();
        todd.InterviewCandidate();
    }
}
