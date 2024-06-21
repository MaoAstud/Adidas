using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Logica.Implementations;
using Datos.Models;
using AccesoDatos.Repositories;

namespace AdidasApi.Controllers
{
    public class ProductosController : ApiController
    {
        private readonly IProductosService _productosService;

        public ProductosController()
        {
            // Inicializar el repositorio y el servicio
            IProductosRepository productosRepository = new ProductosRepository();
            _productosService = new ProductosService(productosRepository);
        }

        // GET: api/productos
        [HttpGet]
        public IEnumerable<Productos> GetProductos()
        {
            return _productosService.GetProductos();
        }

        // GET: api/productos/5
        [HttpGet]
        public IHttpActionResult GetProducto(int id)
        {
            var producto = _productosService.GetProducto(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // POST: api/productos
        [HttpPost]
        public IHttpActionResult PostProducto(Productos producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _productosService.AddProducto(producto);

            return CreatedAtRoute("DefaultApi", new { id = producto.id_producto }, producto);
        }

        // PUT: api/productos/5
        [HttpPut]
        public IHttpActionResult PutProducto(int id, Productos producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.id_producto)
            {
                return BadRequest();
            }

            _productosService.UpdateProducto(producto);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/productos/5
        [HttpDelete]
        public IHttpActionResult DeleteProducto(int id)
        {
            var producto = _productosService.GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            _productosService.DeleteProducto(id);

            return Ok(producto);
        }
    }
}
