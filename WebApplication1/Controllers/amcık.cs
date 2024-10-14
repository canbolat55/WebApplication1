using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class amcık : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine( "hello world");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);
            return View();
        }
    }
}
