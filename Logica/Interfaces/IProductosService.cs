using System.Collections.Generic;
using Datos;
using AccesoDatos;

namespace Logica.Interfaces
{
    public interface IProductosService
    {
        IEnumerable<Productos> GetProductos();
        Productos GetProducto(int id);
        void AddProducto(Productos producto);
        void UpdateProducto(Productos producto);
        void DeleteProducto(int id);
    }
}


