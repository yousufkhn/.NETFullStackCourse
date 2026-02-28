using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OnboardingSelectorApp.Models;

namespace OnboardingSelectorApp.DataAccess
{
    public class CandidateRepository
    {
        private readonly string connectionString = "Server=.\\Sqlexpress;Integrated Security=SSPI;Database=OnboardingDB;TrustServerCertificate=true";

        public bool AddCandidate(Candidate candidate)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"Insert into Candidates(fullname,email,college,cgpa,skills,InterviewScore,status) 
                                Values (@FullName,@Email,@College,@CGPA,@Skills,@InterviewScore,@Status)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@FullName", candidate.FullName);
                cmd.Parameters.AddWithValue("@Email", candidate.Email);
                cmd.Parameters.AddWithValue("@College", candidate.College);
                cmd.Parameters.AddWithValue("@CGPA", candidate.CGPA);
                cmd.Parameters.AddWithValue("@Skills", candidate.Skills);
                cmd.Parameters.AddWithValue("@InterviewScore", candidate.InterviewScore);
                cmd.Parameters.AddWithValue("@Status", candidate.Status);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0) return true;
                else return false;
            }
        }

        public List<Candidate> GetAllCandidates()
        {
            List<Candidate> candidates = new List<Candidate>();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Candidates";

                SqlCommand cmd = new SqlCommand(query,conn);

                conn.Open();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Candidate candidate = new Candidate
                        {
                            // ado.net gives us raw object so we need to manually convert
                            CandidateId = Convert.ToInt32(reader["CandidateId"]),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            College = reader["College"].ToString(),
                            CGPA = Convert.ToDecimal(reader["CGPA"]),
                            Skills = reader["Skills"].ToString(),
                            InterviewScore = Convert.ToInt32(reader["InterviewScore"]),
                            Status = reader["Status"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        };
                        candidates.Add(candidate);
                    }
                }
            }
            return candidates;
        }

        public Candidate GetCandidateById(int id)
        {
            Candidate candidate = null;

            using(SqlConnection conn= new SqlConnection(connectionString))
            {
                string query = @"Select * from candidates where CandidateId=@Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        candidate = new Candidate
                        {
                            CandidateId = Convert.ToInt32(reader["CandidateId"]),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            College = reader["College"].ToString(),
                            CGPA = Convert.ToDecimal(reader["CGPA"]),
                            Skills = reader["Skills"].ToString(),
                            InterviewScore = Convert.ToInt32(reader["InterviewScore"]),
                            Status = reader["Status"].ToString(),
                            CreatedDate = Convert.ToDateTime(reader["CreatedDate"])
                        };
                    }
                }
            }
            return candidate;
        }

        public bool UpdateCandidateStatus(int id,string status)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"Update candidates set status = @status where CandidateId = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool DeleteCandidate(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"delete from Candidates 
                         where CandidateId = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public int CountSelectedCandidates()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select count(*) from Candidates where Status = 'Selected'";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

    }
}
