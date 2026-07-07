using DataAccessLayer.Models;
using BookManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        //[ActionName("FirstActionMethod")]
        //public string Index1()
        //{
        //    return "First Action method";
        //}
        public IActionResult Index()
        {
            BookService bookService = new BookService();
            List<Book> books = bookService.GetAllBooks();
            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid) 
            {
                BookService bookService = new BookService();
                int result = bookService.SaveBook(book);

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditBook(int id) 
        {
            BookService bookService = new BookService();
            var book = bookService.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            BookService bookService = new BookService();
            int result = bookService.updateBook(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteBook(int id)
        {
            BookService bookService = new BookService();
            int result = bookService.deleteBook(id);

            return RedirectToAction("Index");
        }

    }
}
