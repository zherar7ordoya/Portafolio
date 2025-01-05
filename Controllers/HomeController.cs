using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;

namespace Portafolio.Controllers
{
    public class HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorio, IConfiguration config) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly IRepositorioProyectos _repositorio = repositorio;
        private readonly IConfiguration _config = config;

        // Acciones de controlador..............................................

        public IActionResult Index()
        {
            // Probando el uso de la configuración de la aplicación
            var modo = _config["Modo"];

            // Probando el uso de un logger (registro de eventos, bitácora)
            _logger.LogTrace("Registrando un evento del tipo Trace.");
            _logger.LogDebug("Registrando un evento del tipo Debug.");
            _logger.LogInformation("Registrando un evento del tipo Information.");
            _logger.LogWarning("Registrando un evento del tipo Warning.");
            _logger.LogError("Registrando un evento del tipo Error.");
            _logger.LogCritical("Registrando un evento del tipo Critical");

            _logger.LogInformation("{Modo}", modo);

            var proyectos = _repositorio.ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = _repositorio.ObtenerProyectos();
            return View(proyectos);
        }

        //......................................................................

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
