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
                    Titulo = "Proyecto 1",
                    Descripcion = "Descripción del proyecto 1",
                    Link = "https://amazon.com",
                    ImagenUrl = ""
                },
                new Proyecto
                {
                    Titulo = "Proyecto 2",
                    Descripcion = "Descripción del proyecto 2",
                    Link = "https://amazon.com",
                    ImagenUrl = ""
                },

                new Proyecto
                {
                    Titulo = "Proyecto 3",
                    Descripcion = "Descripción del proyecto 3",
                    Link = "https://amazon.com",
                    ImagenUrl = ""
                }
            };
        }

    }
}
