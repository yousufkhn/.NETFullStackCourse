using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Repository
{
    public class MemoryBookRepository : IBookRepository
    {
        private Dictionary<int, Book> memoryBook;
        public MemoryBookRepository()
        {
            memoryBook = new()
            {
                {101, new Book{BookId = 101,Title = "Clean Code", Author = "Robert C. Martin", Price = 500} },
                {102, new Book{BookId = 102,Title = "Clean Code 2", Author = "Robert C. Martin", Price = 600} },
                {103, new Book{BookId = 103,Title = "Clean Code 3", Author = "Robert C. Martin", Price = 700} },

            };
        }
        public Task AddBook(Book book)
        {
            memoryBook.Add(book.BookId,book);
            return Task.CompletedTask;
        }

        public Task DeleteBook(int id)
        {
            memoryBook.Remove(id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Book>> GetAllBook()
        {
            return Task.FromResult(memoryBook.Values.AsEnumerable());
        }

        public Task<Book?> GetBookById(int id)
        {
            return Task.FromResult(memoryBook.FirstOrDefault(b=>b.Value.BookId == id).Value);
        }
    }
}
