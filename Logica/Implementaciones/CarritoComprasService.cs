using System.Collections.Generic;
using AccesoDatos;
using AccesoDatos.Interfaces;
using Datos;
using Logica;
using Logica.Interfaces;

namespace Logica.Implementations
{
    public class CarritoComprasService : ICarritoComprasService
    {
        private readonly ICarritoComprasRepository _carritoComprasRepository;

        public CarritoComprasService(ICarritoComprasRepository carritoComprasRepository)
        {
            _carritoComprasRepository = carritoComprasRepository;
        }

        public IEnumerable<CarritoCompras> GetCarritos()
        {
            return _carritoComprasRepository.GetCarritos();
        }

        public CarritoCompras GetCarrito(int id)
        {
            return _carritoComprasRepository.GetCarrito(id);
        }

        public void AddCarrito(CarritoCompras carrito)
        {
            _carritoComprasRepository.AddCarrito(carrito);
        }

        public void UpdateCarrito(CarritoCompras carrito)
        {
            _carritoComprasRepository.UpdateCarrito(carrito);
        }

        public void DeleteCarrito(int id)
        {
            _carritoComprasRepository.DeleteCarrito(id);
        }
    }
}
