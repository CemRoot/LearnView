using Microsoft.AspNetCore.Mvc;

namespace LearnView.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
