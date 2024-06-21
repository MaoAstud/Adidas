using AccesoDatos;
using AccesoDatos.Repositorios;
using Adidas.DTOS;
using Logica.Implementaciones;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Adidas.Controllers
{
    public class DetalleCarritoController : ApiController
    {
        private readonly IDetalleCarritoService _detalleCarritoService;

        // Constructor sin parámetros para Web API
        public DetalleCarritoController()
        {
            var detalleCarritoRepository = new DetalleCarritoRepository();
            _detalleCarritoService = new DetalleCarritoService(detalleCarritoRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public DetalleCarritoController(IDetalleCarritoService detalleCarritoService)
        {
            _detalleCarritoService = detalleCarritoService;
        }

        // GET: api/detallecarrito
        [HttpGet]
        public IEnumerable<DetalleCarritoDto> GetDetalles()
        {
            var detalles = _detalleCarritoService.GetDetalles();
            return detalles.Select(d => new DetalleCarritoDto
            {
                IdDetalle = d.id_detalle,
                CarritoId = d.carrito_id,
                ProductoId = d.producto_id,
                Cantidad = d.cantidad,
                AgregadoFecha = d.agregado_fecha
            }).ToList();
        }

        // GET: api/detallecarrito/5
        [HttpGet]
        public IHttpActionResult GetDetalle(int id)
        {
            var detalle = _detalleCarritoService.GetDetalle(id);
            if (detalle == null)
            {
                return NotFound();
            }

            var detalleDto = new DetalleCarritoDto
            {
                IdDetalle = detalle.id_detalle,
                CarritoId = detalle.carrito_id,
                ProductoId = detalle.producto_id,
                Cantidad = detalle.cantidad,
                AgregadoFecha = detalle.agregado_fecha
            };

            return Ok(detalleDto);
        }

        // POST: api/detallecarrito
        [HttpPost]
        public IHttpActionResult PostDetalle(DetalleCarritoDto detalleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var detalle = new DetalleCarrito
            {
                carrito_id = detalleDto.CarritoId,
                producto_id = detalleDto.ProductoId,
                cantidad = detalleDto.Cantidad,
                agregado_fecha = detalleDto.AgregadoFecha
            };

            _detalleCarritoService.AddDetalle(detalle);

            return CreatedAtRoute("DefaultApi", new { id = detalle.id_detalle }, detalleDto);
        }

        // PUT: api/detallecarrito/5
        [HttpPut]
        public IHttpActionResult PutDetalle(int id, DetalleCarritoDto detalleDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != detalleDto.IdDetalle)
            {
                return BadRequest();
            }

            var detalle = new DetalleCarrito
            {
                id_detalle = detalleDto.IdDetalle,
                carrito_id = detalleDto.CarritoId,
                producto_id = detalleDto.ProductoId,
                cantidad = detalleDto.Cantidad,
                agregado_fecha = detalleDto.AgregadoFecha
            };

            _detalleCarritoService.UpdateDetalle(detalle);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/detallecarrito/5
        [HttpDelete]
        public IHttpActionResult DeleteDetalle(int id)
        {
            var detalle = _detalleCarritoService.GetDetalle(id);
            if (detalle == null)
            {
                return NotFound();
            }

            _detalleCarritoService.DeleteDetalle(id);

            return Ok();
        }
    }
}