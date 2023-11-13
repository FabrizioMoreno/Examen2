using AccesoDatos.Context;
using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private AutorDAO autoresDAO = new AutorDAO();
       

        [HttpGet]
        public List<Autor> GetAutores()
        {
            var autores = autoresDAO.SeleccionarTodosAutores();
            return autores;
        }
        
        [HttpGet("autor/{id}")]
        public Autor ObtenerAutores(int id)
        {
            return autoresDAO.ObtenerAutor(id); 
        }

        [HttpPost]
        public bool insertarAutor([FromBody] Autor autor)
        {
            return autoresDAO.insertar (autor.Id, autor.Name);
        }
    }
}
