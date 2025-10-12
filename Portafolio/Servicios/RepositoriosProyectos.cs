using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositoriosProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>
            {
                new Proyecto
                {
                    Titulo = "Mi Moto Ideal",
                    Descripcion = "App móvil para visualizar, comparar y recomendar motocicletas en Colombia realizada en Kotlin Jetpack Compose",
                    Link = "https://github.com/Jcastaho/AppMotosKotlin",
                    ImagenUrl = "/imagenes/img_motos1.webp"
                },
                new Proyecto
                {
                    Titulo = "Ecommerce",
                    Descripcion = "Ecommerce movil para publicar productos, con modo de administrador o de cliente",
                    Link = "https://github.com/Jcastaho/EcommerceApp",
                    ImagenUrl = "/imagenes/img_ecommerce_1.png"
                },
                new Proyecto
                {
                    Titulo = "Windows 95",
                    Descripcion = "Interfaz grafica retro al estilo Windows 95",
                    Link = "https://github.com/Jcastaho/Win95versionWebCode",
                    ImagenUrl = "/imagenes/img_win_1.png"
                },
                new Proyecto
                {
                    Titulo = "Online Shop",
                    Descripcion = "Aplicacion movil de una tienda de ropa en online",
                    Link = "https://github.com/Jcastaho/OnlineShop",
                    ImagenUrl = "/imagenes/img_shoping_2.png"
                },
                new Proyecto
                {
                    Titulo = "Gemini Chat",
                    Descripcion = "Aplicacion movil en la que se integra Gemini en un chat",
                    Link = "https://github.com/Jcastaho/GeminiBot",
                    ImagenUrl = "/imagenes/img_gemini_1.png"
                },
                new Proyecto
                {
                    Titulo = "Buscador de Gifs",
                    Descripcion = "Aplicacion web que permite buscar gifs",
                    Link = "https://github.com/Jcastaho/react-gif-expert",
                    ImagenUrl = "/imagenes/img_buscadorgif.webp"
                }

            };
        }

    }
}
