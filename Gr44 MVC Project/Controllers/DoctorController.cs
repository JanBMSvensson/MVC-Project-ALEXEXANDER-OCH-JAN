using Gr44_MVC_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gr44_MVC_Project.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }



        public IActionResult Diagnose(decimal temperature, string TempScale)
        {

            TemperatureScale scale = Enum.Parse<TemperatureScale>(TempScale);
            var temp = new Temperature(temperature, scale);
            var doctor = new Doctor(temp);
            return View(doctor);
            
        }
    }
}
