using Microsoft.AspNetCore.Mvc;
using PageCounterApp.Services;

namespace PageCounterApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPageCounterService _pageCounterService;
        public HomeController(IPageCounterService pageCounterService)
        {
            _pageCounterService = pageCounterService;
        }
        public IActionResult Index()
        {
            int visitCount = _pageCounterService.IncrementPageCount("Home");
            return View(visitCount);
        }
        public IActionResult OtherPage()
        {
            int visitCount = _pageCounterService.IncrementPageCount("OtherPage");
            return View(visitCount);
        }
    }
}