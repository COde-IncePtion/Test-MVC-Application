using Microsoft.AspNetCore.Mvc;
using TestMvcApplication.Models;

namespace TestMvcApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET
        public IActionResult Index()
        {
            // Fetch details from database 
            
            Student student = new Student(4114, "Ashish Rawat");

            ViewData["student"] = student;
            return View(student);
        }
    }
}