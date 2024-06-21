using System.Collections.Generic;
using AccesoDatos;

namespace AccesoDatos.Interfaces
{
    public interface ICarritoComprasRepository
    {
        IEnumerable<CarritoCompras> GetCarritos();
        CarritoCompras GetCarrito(int id);
        void AddCarrito(CarritoCompras carrito);
        void UpdateCarrito(CarritoCompras carrito);
        void DeleteCarrito(int id);
    }
}

