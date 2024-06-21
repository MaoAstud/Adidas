using AccesoDatos.Interfaces;
using AccesoDatos;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementaciones
{
    public class DetalleCarritoService : IDetalleCarritoService
    {
        private readonly IDetalleCarritoRepository _detalleCarritoRepository;

        public DetalleCarritoService(IDetalleCarritoRepository detalleCarritoRepository)
        {
            _detalleCarritoRepository = detalleCarritoRepository;
        }

        public IEnumerable<DetalleCarrito> GetDetalles()
        {
            return _detalleCarritoRepository.GetDetalles();
        }

        public DetalleCarrito GetDetalle(int id)
        {
            return _detalleCarritoRepository.GetDetalle(id);
        }

        public void AddDetalle(DetalleCarrito detalle)
        {
            _detalleCarritoRepository.AddDetalle(detalle);
        }

        public void UpdateDetalle(DetalleCarrito detalle)
        {
            _detalleCarritoRepository.UpdateDetalle(detalle);
        }

        public void DeleteDetalle(int id)
        {
            _detalleCarritoRepository.DeleteDetalle(id);
        }
    }
}
