using Memoria_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Memoria_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            bool? darkModeEnabled = Request.Cookies["dark-mode"] == "true";
            ViewBag.DarkModeEnabled = darkModeEnabled;
            return View();
        }





        public IActionResult Cuentas()
        {
            return View();
        }

        public IActionResult Jurisdiccional()
        {
            return View();
        }

        public IActionResult Fiscalizadora()
        {
            return View();
        }

        public IActionResult Reglamentaria()
        {
            return View();
        }

        public IActionResult Consultiva()
        {
            return View();
        }

        public IActionResult Organigrama()
        {
            return View();
        }

        public IActionResult QuienesSomos()
        {
            return View();
        }

        public IActionResult RecursosHumanos()
        {
            return View();
        }

        public IActionResult Procesos()
        {
            return View();
        }

        public IActionResult Calidad()
        {
            return View();
        }

        public IActionResult AuditoriaExterna()
        {
            return View();
        }

        public IActionResult Actividades()
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