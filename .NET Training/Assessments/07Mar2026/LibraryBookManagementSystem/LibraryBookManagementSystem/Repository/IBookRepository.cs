using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBook();
        Task<Book?> GetBookById(int id);
        Task AddBook(Book book);
        Task DeleteBook(int id);
    }
}
