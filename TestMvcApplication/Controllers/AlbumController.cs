using Microsoft.AspNetCore.Mvc;

namespace TestMvcApplication.Controllers
{
    public class AlbumController : Controller
    {
        // GET
        [HttpGet("album/index")]
        public IActionResult Index()
        { 
            string message = "Hey there... it's Ashish Rawat";
            ViewData["message"] = message;
            
            return View();
        }
    }
}