using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorio;
        private readonly IServicioEmail servicioEmail;

        public HomeController(ILogger<HomeController> logger,
            IRepositorioProyectos repositorio,
            IServicioEmail servicioEmail
            )
        {
            _logger = logger;
            this.repositorio = repositorio;
            this.servicioEmail = servicioEmail;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Visita a la página principal");
            var proyectos = repositorio.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel()
            {
                Proyectos = proyectos
            };
            return View(modelo);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
        {
            await servicioEmail.Enviar(contactoViewModel);
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorio.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
