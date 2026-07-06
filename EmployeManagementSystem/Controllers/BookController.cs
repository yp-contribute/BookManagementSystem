using Microsoft.AspNetCore.Mvc;

namespace BookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [ActionName("FirstActionMethod")]
        public string Index1()
        {
            return "First Action method";
        }


    }
}
