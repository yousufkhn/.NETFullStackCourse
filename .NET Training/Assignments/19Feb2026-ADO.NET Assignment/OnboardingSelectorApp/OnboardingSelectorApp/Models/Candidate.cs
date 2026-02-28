using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingSelectorApp.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string College { get; set; }
        public decimal CGPA { get; set; }
        public string Skills { get; set; }
        public int InterviewScore { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
