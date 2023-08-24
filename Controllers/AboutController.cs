using Microsoft.AspNetCore.Mvc;

namespace fruit.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
