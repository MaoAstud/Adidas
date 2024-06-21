using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Interfaces;
using Datos;
using Logica.Interfaces;

namespace Logica.Implementations
{
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _productosRepository;

        public ProductosService(IProductosRepository productosRepository)
        {
            _productosRepository = productosRepository;
        }

        public IEnumerable<Productos> GetProductos()
        {
            return _productosRepository.GetProductos();
        }

        public Productos GetProducto(int id)
        {
            return _productosRepository.GetProducto(id);
        }

        public void AddProducto(Productos producto)
        {
            _productosRepository.AddProducto(producto);
        }

        public void UpdateProducto(Productos producto)
        {
            _productosRepository.UpdateProducto(producto);
        }

        public void DeleteProducto(int id)
        {
            _productosRepository.DeleteProducto(id);
        }
    }
}


