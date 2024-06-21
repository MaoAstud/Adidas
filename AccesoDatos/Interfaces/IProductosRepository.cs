using System.Collections.Generic;
using AccesoDatos;
namespace AccesoDatos.Interfaces
{
    public interface IProductosRepository
    {
        IEnumerable<Productos> GetProductos();
        Productos GetProducto(int id);
        void AddProducto(Productos producto);
        void UpdateProducto(Productos producto);
        void DeleteProducto(int id);
    }
}

