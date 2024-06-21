using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IDetalleCarritoRepository
    {
        IEnumerable<DetalleCarrito> GetDetalles();
        DetalleCarrito GetDetalle(int id);
        void AddDetalle(DetalleCarrito detalle);
        void UpdateDetalle(DetalleCarrito detalle);
        void DeleteDetalle(int id);
    }
}
