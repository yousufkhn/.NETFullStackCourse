using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnboardingSelectorApp.Models;
using OnboardingSelectorApp.Business;

namespace OnboardingSelectorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CandidateService service = new CandidateService();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Early Onboarding Candidate Management System ===");
                Console.WriteLine("1. Add Candidate");
                Console.WriteLine("2. View All Candidates");
                Console.WriteLine("3. Search Candidate By ID");
                Console.WriteLine("4. Update Candidate Status");
                Console.WriteLine("5. Delete Candidate");
                Console.WriteLine("6. Count Selected Candidates");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCandidate(service);
                        break;
                    case 2:
                        ViewAllCandidates(service);
                        break;
                    case 3:
                        SearchCandidate(service);
                        break;
                    case 4:
                        UpdateStatus(service);
                        break;
                    case 5:
                        DeleteCandidate(service);
                        break;
                    case 6:
                        CountSelected(service);
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddCandidate(CandidateService service)
        {
            try
            {
                Candidate candidate = new Candidate();

                Console.Write("Full Name: ");
                candidate.FullName = Console.ReadLine();

                Console.Write("Email: ");
                candidate.Email = Console.ReadLine();

                Console.Write("College: ");
                candidate.College = Console.ReadLine();

                Console.Write("CGPA: ");
                candidate.CGPA = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Skills: ");
                candidate.Skills = Console.ReadLine();

                Console.Write("Interview Score: ");
                candidate.InterviewScore = Convert.ToInt32(Console.ReadLine());

                Console.Write("Status: ");
                candidate.Status = Console.ReadLine();

                bool result = service.AddCandidate(candidate);

                if (result)
                {
                    Console.WriteLine("Candidate Added Successfully!");
                }
                else
                {
                    Console.WriteLine("Failed to add candidate");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void ViewAllCandidates(CandidateService service)
        {
            List<Candidate> candidates = service.GetAllCandidates();

            foreach(var c in candidates)
            {
                Console.WriteLine($"{c.FullName} {c.CGPA} {c.InterviewScore} {c.Status}");
            }
        }

        static void SearchCandidate(CandidateService service)
        {
            Console.Write("Enter Candidate ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Candidate c = service.GetCandidateById(id);

            if (c != null)
            {
                Console.WriteLine($"Name: {c.FullName}");
                Console.WriteLine($"Email: {c.Email}");
                Console.WriteLine($"College: {c.College}");
                Console.WriteLine($"CGPA: {c.CGPA}");
                Console.WriteLine($"Interview Score: {c.InterviewScore}");
                Console.WriteLine($"Status: {c.Status}");
            }
            else
            {
                Console.WriteLine("Candidate not found.");
            }
        }

        static void UpdateStatus(CandidateService service)
        {
            Console.Write("Enter Candidate ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter New Status: ");
            string status = Console.ReadLine();

            bool result = service.UpdateCandidateStatus(id, status);

            Console.WriteLine(result ? "Status updated successfully." : "Update failed.");
        }

        static void DeleteCandidate(CandidateService service)
        {
            Console.Write("Enter Candidate ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            bool result = service.DeleteCandidate(id);

            Console.WriteLine(result ? "Candidate deleted successfully." : "Delete failed.");
        }

        static void CountSelected(CandidateService service)
        {
            int count = service.CountSelectedCandidates();
            Console.WriteLine($"Total Selected Candidates: {count}");
        }


    }
}
