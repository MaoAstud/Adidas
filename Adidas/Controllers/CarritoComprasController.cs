using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Datos;
using AccesoDatos;
using AccesoDatos.Repositories;
using Logica.Implementations;
using Adidas.DTOS;
using System.Linq;

namespace AdidasApi.Controllers
{
    public class CarritoComprasController : ApiController
    {
        private readonly ICarritoComprasService _carritoComprasService;

        // Constructor sin parámetros para Web API
        public CarritoComprasController()
        {
            var carritoComprasRepository = new CarritoComprasRepository();
            _carritoComprasService = new CarritoComprasService(carritoComprasRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public CarritoComprasController(ICarritoComprasService carritoComprasService)
        {
            _carritoComprasService = carritoComprasService;
        }

        // GET: api/carritocompras
        [HttpGet]
        public IEnumerable<CarritoComprasDto> GetCarritos()
        {
            var carritos = _carritoComprasService.GetCarritos();
            return carritos.Select(c => new CarritoComprasDto
            {
                IdCarrito = c.id_carrito,
                UsuarioId = c.usuario_id,
                CreacionFecha = c.creacion_fecha,
                SessionId = c.session_id
            }).ToList();
        }

        // GET: api/carritocompras/5
        [HttpGet]
        public IHttpActionResult GetCarrito(int id)
        {
            var carrito = _carritoComprasService.GetCarrito(id);
            if (carrito == null)
            {
                return NotFound();
            }

            var carritoDto = new CarritoComprasDto
            {
                IdCarrito = carrito.id_carrito,
                UsuarioId = carrito.usuario_id,
                CreacionFecha = carrito.creacion_fecha,
                SessionId = carrito.session_id
            };

            return Ok(carritoDto);
        }

        // POST: api/carritocompras
        [HttpPost]
        public IHttpActionResult PostCarrito(CarritoComprasDto carritoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var carrito = new CarritoCompras
            {
                usuario_id = carritoDto.UsuarioId,
                creacion_fecha = carritoDto.CreacionFecha,
                session_id = carritoDto.SessionId
            };

            _carritoComprasService.AddCarrito(carrito);

            return CreatedAtRoute("DefaultApi", new { id = carrito.id_carrito }, carritoDto);
        }

        // PUT: api/carritocompras/5
        [HttpPut]
        public IHttpActionResult PutCarrito(int id, CarritoComprasDto carritoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carritoDto.IdCarrito)
            {
                return BadRequest();
            }

            var carrito = new CarritoCompras
            {
                id_carrito = carritoDto.IdCarrito,
                usuario_id = carritoDto.UsuarioId,
                creacion_fecha = carritoDto.CreacionFecha,
                session_id = carritoDto.SessionId
            };

            _carritoComprasService.UpdateCarrito(carrito);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/carritocompras/5
        [HttpDelete]
        public IHttpActionResult DeleteCarrito(int id)
        {
            var carrito = _carritoComprasService.GetCarrito(id);
            if (carrito == null)
            {
                return NotFound();
            }

            _carritoComprasService.DeleteCarrito(id);

            return Ok();

        }
    }
}
