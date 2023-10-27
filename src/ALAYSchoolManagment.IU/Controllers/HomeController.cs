using System.Diagnostics;
using ALAYSchoolManager.Application.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManager.Presentation.IU.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dashboard1()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}