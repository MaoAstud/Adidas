using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Logica.Implementations;
using Datos.Models;
using AccesoDatos.Repositories;

namespace AdidasApi.Controllers
{
    public class CarritoComprasController : ApiController
    {
        private readonly ICarritoComprasService _carritoComprasService;

        public CarritoComprasController()
        {
            // Inicializar el repositorio y el servicio
            ICarritoComprasRepository carritoComprasRepository = new CarritoComprasRepository();
            _carritoComprasService = new CarritoComprasService(carritoComprasRepository);
        }

        // GET: api/carritocompras
        [HttpGet]
        public IEnumerable<CarritoCompras> GetCarritos()
        {
            return _carritoComprasService.GetCarritos();
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

            return Ok(carrito);
        }

        // POST: api/carritocompras
        [HttpPost]
        public IHttpActionResult PostCarrito(CarritoCompras carrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _carritoComprasService.AddCarrito(carrito);

            return CreatedAtRoute("DefaultApi", new { id = carrito.id_carrito }, carrito);
        }

        // PUT: api/carritocompras/5
        [HttpPut]
        public IHttpActionResult PutCarrito(int id, CarritoCompras carrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carrito.id_carrito)
            {
                return BadRequest();
            }

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

            return Ok(carrito);
        }
    }
}
