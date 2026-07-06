using DataAccessLayer.Models;
using BookManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookService bookService = new BookService();
            List<Book> books = bookService.GetAllBooks();
            return View(books);
        }




        //[ActionName("FirstActionMethod")]
        //public string Index1()
        //{
        //    return "First Action method";
        //}


    }
}
