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
                    Titulo = "SocialPreview",
                    Descripcion = "Generardor en Python (Pillow) para generar las imágenes de 1280x640px que pide GitHub para la SocialPreview de los repositorios.",
                    Link = "https://github.com/zherar7ordoya/SocialPreview",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/SocialPreview/refs/heads/main/assets/python.png"
                },
                new ()
                {
                    Titulo = "ModernWeb",
                    Descripcion = "Mark Price - C# 13 and .NET 9.",
                    Link = "https://github.com/zherar7ordoya/ModernWeb",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/ModernWeb/refs/heads/main/assets/web.jpeg"
                },
                new ()
                {
                    Titulo = "Gerardo Tordoya",
                    Descripcion = "zherar7ordoya/zherar7ordoya is a special repository. Its README.md will appear on your public profile.",
                    Link = "https://github.com/zherar7ordoya/zherar7ordoya",
                    ImagenURL = "https://raw.githubusercontent.com/zherar7ordoya/zherar7ordoya/refs/heads/main/assets/top-gun.jpg"
                }
            };

            return proyectos;
        }
    }
}
