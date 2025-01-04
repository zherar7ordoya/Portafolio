using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Acciones de controlador..............................................
        
        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel { Proyectos = proyectos };
            return View(modelo);
        }

        private static List<Proyecto> ObtenerProyectos()
        {
            var proyectos = new List<Proyecto>
            {
                new() {
                    Titulo = "CursadaTFC",
                    Descripcion = "Materiales provistos durante la tutoría del Trabajo Final de Carrera",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/CursadaTFC/refs/heads/main/uai.jpg",
                    Link = "https://github.com/zherar7ordoya/CursadaTFC"
                },
                new ()
                {
                    Titulo = "XLS",
                    Descripcion = "Herramientas para el trabajo en Editora SA",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/XLS/refs/heads/master/vba.png",
                    Link = "https://github.com/zherar7ordoya/XLS"
                },
                new ()
                {
                    Titulo = "Xperiments",
                    Descripcion = "Pequeños experimentos con diferentes lenguajes",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/Xperiments/refs/heads/main/xperiments.jpg",
                    Link = "https://github.com/zherar7ordoya/Xperiments"
                }
            };

            return proyectos;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //......................................................................

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
