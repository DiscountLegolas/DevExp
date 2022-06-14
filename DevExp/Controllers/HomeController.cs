using DevExp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevExp.RepositoryPattern.Services.Abstract;

namespace DevExp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISalesService _salesService;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,ISalesService salesService)
        {
            _salesService = salesService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Model model = new Model();
            model.Sales = _salesService.GetAllProductSales();
            return View(model);
        }

        public IActionResult Privacy()
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