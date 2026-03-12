using LibraryBookManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;

        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> List()
        {
            var books = await _repo.GetAllBook();
            return View(books);
        }

        public async Task<IActionResult> Details(int id)
        {
            var book = await _repo.GetBookById(id);

            if (book == null)
                return NotFound();

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            if (!ModelState.IsValid)
                return View(book);

            await _repo.AddBook(book);

            return RedirectToAction(nameof(List));
        }
    }
}