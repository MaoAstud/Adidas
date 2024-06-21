using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Logica.Implementations;
using Datos.Models;
using AccesoDatos.Repositories;

namespace AdidasApi.Controllers
{
    public class CategoriasController : ApiController
    {
        private readonly ICategoriasService _categoriasService;

        public CategoriasController()
        {
            // Inicializar el repositorio y el servicio
            ICategoriasRepository categoriasRepository = new CategoriasRepository();
            _categoriasService = new CategoriasService(categoriasRepository);
        }

        // GET: api/categorias
        [HttpGet]
        public IEnumerable<Categorias> GetCategorias()
        {
            return _categoriasService.GetCategorias();
        }

        // GET: api/categorias/5
        [HttpGet]
        public IHttpActionResult GetCategoria(int id)
        {
            var categoria = _categoriasService.GetCategoria(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // POST: api/categorias
        [HttpPost]
        public IHttpActionResult PostCategoria(Categorias categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _categoriasService.AddCategoria(categoria);

            return CreatedAtRoute("DefaultApi", new { id = categoria.id_categoria }, categoria);
        }

        // PUT: api/categorias/5
        [HttpPut]
        public IHttpActionResult PutCategoria(int id, Categorias categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoria.id_categoria)
            {
                return BadRequest();
            }

            _categoriasService.UpdateCategoria(categoria);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/categorias/5
        [HttpDelete]
        public IHttpActionResult DeleteCategoria(int id)
        {
            var categoria = _categoriasService.GetCategoria(id);
            if (categoria == null)
            {
                return NotFound();
            }

            _categoriasService.DeleteCategoria(id);

            return Ok(categoria);
        }
    }
}
