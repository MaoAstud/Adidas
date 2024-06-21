using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
    public interface IDetalleCarritoService
    {
        IEnumerable<DetalleCarrito> GetDetalles();
        DetalleCarrito GetDetalle(int id);
        void AddDetalle(DetalleCarrito detalle);
        void UpdateDetalle(DetalleCarrito detalle);
        void DeleteDetalle(int id);
    }
}
