using System.Collections.Generic;
using AccesoDatos;
using Datos;

namespace Logica.Interfaces
{
    public interface ICarritoComprasService
    {
        IEnumerable<CarritoCompras> GetCarritos();
        CarritoCompras GetCarrito(int id);
        void AddCarrito(CarritoCompras carrito);
        void UpdateCarrito(CarritoCompras carrito);
        void DeleteCarrito(int id);
    }
}
