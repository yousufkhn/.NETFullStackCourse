using StudentPortal.Models;

namespace StudentPortal.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllAsync(string q = null);
        Task<Student> GetByIdAsync(int id);
        Task<Student> CreateAsync(Student student);
        Task UpdateAsync(int id, Student student);
        Task DeleteAsync(int id);
    }
}
