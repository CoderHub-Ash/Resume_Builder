using Microsoft.AspNetCore.Mvc;

namespace ResumeBuilder.Domain
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
