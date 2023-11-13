using AccesoDatos.Context;
using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private LibroDAO librosDAO = new LibroDAO();
        

        [HttpGet]
        public List<Libro> GetAutores()
        {
            var libros = librosDAO.SeleccionarTodosLibros();
            return libros;
        }
        [HttpGet("libro/{id}")]
        public Libro ObtenerLibros(int id)
        {
            return librosDAO.ObtenerLibro(id);
        }

        [HttpPost]
        public bool insertarLibro([FromBody] Libro libro)
        {
            return librosDAO.insertar(libro.Id, libro.Title, libro.AutorId, libro.Chapters, libro.Pages, libro.Price);
        }


    }
}
