using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScamperersConsoleApp.ScamperersConsoleApp.Models
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public int InterviewScore { get; set; }
    public Candidate (string firstName)
        {
            FirstName = firstName;
        }
    }

}
