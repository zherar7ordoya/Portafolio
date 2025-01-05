using Portafolio.Models;

namespace Portafolio.Services
{
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
                },
                new ()
                {
                    Titulo = "Portafolio",
                    Descripcion = "Proyecto de portafolio personal",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/Portafolio/refs/heads/main/portafolio.jpg",
                    Link = "https://github.com/zherar7ordoya/Xperiments"
                },
                new ()
                {
                    Titulo = "Portafolio",
                    Descripcion = "Proyecto de portafolio personal",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/Portafolio/refs/heads/main/portafolio.jpg",
                    Link = "https://github.com/zherar7ordoya/Xperiments"
                },
                new ()
                {
                    Titulo = "Portafolio",
                    Descripcion = "Proyecto de portafolio personal",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/Portafolio/refs/heads/main/portafolio.jpg",
                    Link = "https://github.com/zherar7ordoya/Xperiments"
                },
            };

            return proyectos;
        }
    }
}
