using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;

namespace Gr44_MVC_Project.Controllers
{
    public class GuessController : Controller
    {
        public IActionResult GuessNumber()
        {
            var rnd = new Random();

            HttpContext.Session.SetInt32("secret", rnd.Next(100) + 1);

            return View();
        }
        [HttpPost]
        public IActionResult GuessNumber(int bestGuess)
        {
            

            (int? secret, int guess) test = (secret: HttpContext.Session.GetInt32("secret"), guess: bestGuess);

            return View(test);
        }
    }
}
