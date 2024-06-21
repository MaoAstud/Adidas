using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Datos;
using AccesoDatos;
using AccesoDatos.Repositorios;
using Logica.Implementaciones;
using Adidas.DTOS;
using System.Linq;

namespace AdidasApi.Controllers
{
    public class ComentariosValoracionesController : ApiController
    {
        private readonly IComentariosValoracionesService _comentariosValoracionesService;

        // Constructor sin parámetros para Web API
        public ComentariosValoracionesController()
        {
            var comentariosValoracionesRepository = new ComentariosValoracionesRepository();
            _comentariosValoracionesService = new ComentariosValoracionesService(comentariosValoracionesRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public ComentariosValoracionesController(IComentariosValoracionesService comentariosValoracionesService)
        {
            _comentariosValoracionesService = comentariosValoracionesService;
        }

        // GET: api/comentariosvaloraciones
        [HttpGet]
        public IEnumerable<ComentariosValoracionesDto> GetComentariosValoraciones()
        {
            var comentarios = _comentariosValoracionesService.GetComentariosValoraciones();
            return comentarios.Select(c => new ComentariosValoracionesDto
            {
                IdComentario = c.id_comentario,
                UsuarioId = c.usuario_id,
                ProductoId = c.producto_id,
                ComentarioTexto = c.comentario_texto,
                Rating = c.rating,
                ComentarioFecha = c.comentario_fecha
            }).ToList();
        }

        // GET: api/comentariosvaloraciones/5
        [HttpGet]
        public IHttpActionResult GetComentarioValoracion(int id)
        {
            var comentario = _comentariosValoracionesService.GetComentarioValoracion(id);
            if (comentario == null)
            {
                return NotFound();
            }

            var comentarioDto = new ComentariosValoracionesDto
            {
                IdComentario = comentario.id_comentario,
                UsuarioId = comentario.usuario_id,
                ProductoId = comentario.producto_id,
                ComentarioTexto = comentario.comentario_texto,
                Rating = comentario.rating,
                ComentarioFecha = comentario.comentario_fecha
            };

            return Ok(comentarioDto);
        }

        // POST: api/comentariosvaloraciones
        [HttpPost]
        public IHttpActionResult PostComentarioValoracion(ComentariosValoracionesDto comentarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comentario = new ComentariosValoraciones
            {
                usuario_id = comentarioDto.UsuarioId,
                producto_id = comentarioDto.ProductoId,
                comentario_texto = comentarioDto.ComentarioTexto,
                rating = comentarioDto.Rating,
                comentario_fecha = comentarioDto.ComentarioFecha
            };

            _comentariosValoracionesService.AddComentarioValoracion(comentario);

            return CreatedAtRoute("DefaultApi", new { id = comentario.id_comentario }, comentarioDto);
        }

        // PUT: api/comentariosvaloraciones/5
        [HttpPut]
        public IHttpActionResult PutComentarioValoracion(int id, ComentariosValoracionesDto comentarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comentarioDto.IdComentario)
            {
                return BadRequest();
            }

            var comentario = new ComentariosValoraciones
            {
                id_comentario = comentarioDto.IdComentario,
                usuario_id = comentarioDto.UsuarioId,
                producto_id = comentarioDto.ProductoId,
                comentario_texto = comentarioDto.ComentarioTexto,
                rating = comentarioDto.Rating,
                comentario_fecha = comentarioDto.ComentarioFecha
            };

            _comentariosValoracionesService.UpdateComentarioValoracion(comentario);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/comentariosvaloraciones/5
        [HttpDelete]
        public IHttpActionResult DeleteComentarioValoracion(int id)
        {
            var comentario = _comentariosValoracionesService.GetComentarioValoracion(id);
            if (comentario == null)
            {
                return NotFound();
            }

            _comentariosValoracionesService.DeleteComentarioValoracion(id);

            return Ok();
        }
    }
}

