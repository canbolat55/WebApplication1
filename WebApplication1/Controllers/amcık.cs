using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class amcık : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine( "hello world");
          

            return View();
        }
    }
}
