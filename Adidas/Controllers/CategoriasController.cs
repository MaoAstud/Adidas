using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Datos;
using AccesoDatos;
using AccesoDatos.Repositorios;
using Logica.Implementaciones;
using AccesoDatos.Repositories;
using Logica.Implementations;
using Adidas.DTOS;
using System.Linq;

namespace AdidasApi.Controllers
{
    public class CategoriasController : ApiController
    {
        private readonly ICategoriasService _categoriasService;

        // Constructor sin parámetros para Web API
        public CategoriasController()
        {
            var categoriasRepository = new CategoriasRepository();
            _categoriasService = new CategoriasService(categoriasRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public CategoriasController(ICategoriasService categoriasService)
        {
            _categoriasService = categoriasService;
        }

        // GET: api/categorias
        [HttpGet]
        public IEnumerable<CategoriaDto> GetCategorias()
        {
            var categorias = _categoriasService.GetCategorias();
            return categorias.Select(c => new CategoriaDto
            {
                IdCategoria = c.id_categoria,
                Nombre = c.nombre,
                Descripcion = c.descripcion,
                PadreId = c.padre_id
            }).ToList();
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

            var categoriaDto = new CategoriaDto
            {
                IdCategoria = categoria.id_categoria,
                Nombre = categoria.nombre,
                Descripcion = categoria.descripcion,
                PadreId = categoria.padre_id
            };

            return Ok(categoriaDto);
        }

        // POST: api/categorias
        [HttpPost]
        public IHttpActionResult PostCategoria(CategoriaDto categoriaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoria = new Categorias
            {
                nombre = categoriaDto.Nombre,
                descripcion = categoriaDto.Descripcion,
                padre_id = categoriaDto.PadreId
            };

            _categoriasService.AddCategoria(categoria);

            return CreatedAtRoute("DefaultApi", new { id = categoria.id_categoria }, categoriaDto);
        }

        // PUT: api/categorias/5
        [HttpPut]
        public IHttpActionResult PutCategoria(int id, CategoriaDto categoriaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != categoriaDto.IdCategoria)
            {
                return BadRequest();
            }

            var categoria = new Categorias
            {
                id_categoria = categoriaDto.IdCategoria,
                nombre = categoriaDto.Nombre,
                descripcion = categoriaDto.Descripcion,
                padre_id = categoriaDto.PadreId
            };

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

            return Ok();
        }
    }
}
