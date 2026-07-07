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
            BookService bookService = new BookService();
            bookService.SaveBook(book);

            return RedirectToAction("Index");
        }

    }
}
