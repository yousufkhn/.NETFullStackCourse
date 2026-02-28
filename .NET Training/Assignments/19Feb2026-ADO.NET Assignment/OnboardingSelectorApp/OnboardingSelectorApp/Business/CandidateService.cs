using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingSelectorApp.DataAccess;
using OnboardingSelectorApp.Models;

namespace OnboardingSelectorApp.Business
{
    public class CandidateService
    {
        private readonly CandidateRepository repository;

        public CandidateService()
        {
            repository = new CandidateRepository();
        }

        public bool AddCandidate(Candidate candidate)
        {
            if(candidate.CGPA < 0 || candidate.CGPA > 10)
            {
                throw new Exception("Invalid CGPA");
            }

            return repository.AddCandidate(candidate);
        }

        public List<Candidate> GetAllCandidates()
        {
            return repository.GetAllCandidates();
        }

        public Candidate GetCandidateById(int id)
        {
            return repository.GetCandidateById(id);
        }

        public bool UpdateCandidateStatus(int id, string status)
        {
            return repository.UpdateCandidateStatus(id, status);
        }

        public bool DeleteCandidate(int id)
        {
            return repository.DeleteCandidate(id);
        }

        public int CountSelectedCandidates()
        {
            return repository.CountSelectedCandidates();
        }
    
    }
}
