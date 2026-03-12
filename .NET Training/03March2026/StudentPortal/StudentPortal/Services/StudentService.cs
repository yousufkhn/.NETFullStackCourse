using StudentPortal.Models;
using StudentPortal.Repository;

namespace StudentPortal.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAllAsync(string q = null)
        {
            return await _repo.GetAllAsync(q);
        }

        public async Task<Student> GetByIdAsync(int id)
        {
            var student = await _repo.GetByIdAsync(id);

            if (student == null)
                throw new Exception("Student not found.");

            return student;
        }

        public async Task<Student> CreateAsync(Student student)
        {
            if (await _repo.EmailExistsAsync(student.Email))
                throw new Exception("Email already exists.");

            await _repo.AddAsync(student);

            return student;
        }

        public async Task UpdateAsync(int id, Student student)
        {
            var existing = await _repo.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Student not found.");

            if (await _repo.EmailExistsAsync(student.Email, id))
                throw new Exception("Email already exists.");

            existing.FullName = student.FullName;
            existing.Email = student.Email;
            existing.Phone = student.Phone;
            existing.Status = student.Status;
            existing.JoinDate = student.JoinDate;

            await _repo.UpdateAsync(existing);
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _repo.GetByIdAsync(id);

            if (existing == null)
                throw new Exception("Student not found.");

            await _repo.DeleteAsync(id);
        }
    }
}
