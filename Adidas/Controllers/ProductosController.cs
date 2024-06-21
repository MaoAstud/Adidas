using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Datos;
using Logica.Implementaciones;
using AccesoDatos;
using AccesoDatos.Interfaces;
using AccesoDatos.Repositories;
using Logica.Implementations;
using Adidas.DTOS;
using System.Linq;

namespace AdidasApi.Controllers
{
    public class ProductosController : ApiController
    {
        private readonly IProductosService _productosService;

        // Constructor sin parámetros para Web API
        public ProductosController()
        {
            var productosRepository = new ProductosRepository();
            _productosService = new ProductosService(productosRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public ProductosController(IProductosService productosService)
        {
            _productosService = productosService;
        }

        // GET: api/productos
        [HttpGet]
        public IEnumerable<ProductoDto> GetProductos()
        {
            var productos = _productosService.GetProductos();
            return productos.Select(p => new ProductoDto
            {
                IdProducto = p.id_producto,
                Nombre = p.nombre,
                Descripcion = p.descripcion,
                Precio = p.precio,
                CategoriaId = p.categoria_id,
                Talla = p.talla,
                Color = p.color,
                Material = p.material,
                Imagen = p.imagen,
                Stock = p.stock,
                FechaRegistro = p.fecha_registro,
                PesoProducto = p.peso_producto
            }).ToList();
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

            var productoDto = new ProductoDto
            {
                IdProducto = producto.id_producto,
                Nombre = producto.nombre,
                Descripcion = producto.descripcion,
                Precio = producto.precio,
                CategoriaId = producto.categoria_id,
                Talla = producto.talla,
                Color = producto.color,
                Material = producto.material,
                Imagen = producto.imagen,
                Stock = producto.stock,
                FechaRegistro = producto.fecha_registro,
                PesoProducto = producto.peso_producto
            };

            return Ok(productoDto);
        }

        // POST: api/productos
        [HttpPost]
        public IHttpActionResult PostProducto(ProductoDto productoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var producto = new Productos
            {
                nombre = productoDto.Nombre,
                descripcion = productoDto.Descripcion,
                precio = productoDto.Precio,
                categoria_id = productoDto.CategoriaId,
                talla = productoDto.Talla,
                color = productoDto.Color,
                material = productoDto.Material,
                imagen = productoDto.Imagen,
                stock = productoDto.Stock,
                fecha_registro = productoDto.FechaRegistro,
                peso_producto = productoDto.PesoProducto
            };

            _productosService.AddProducto(producto);

            return CreatedAtRoute("DefaultApi", new { id = producto.id_producto }, productoDto);
        }

        // PUT: api/productos/5
        [HttpPut]
        public IHttpActionResult PutProducto(int id, ProductoDto productoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productoDto.IdProducto)
            {
                return BadRequest();
            }

            var producto = new Productos
            {
                id_producto = productoDto.IdProducto,
                nombre = productoDto.Nombre,
                descripcion = productoDto.Descripcion,
                precio = productoDto.Precio,
                categoria_id = productoDto.CategoriaId,
                talla = productoDto.Talla,
                color = productoDto.Color,
                material = productoDto.Material,
                imagen = productoDto.Imagen,
                stock = productoDto.Stock,
                fecha_registro = productoDto.FechaRegistro,
                peso_producto = productoDto.PesoProducto
            };

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

            return Ok();
        }
    }
}
