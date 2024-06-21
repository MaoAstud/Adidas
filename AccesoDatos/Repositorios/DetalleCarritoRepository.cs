using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AccesoDatos.Repositorios
{
    public class DetalleCarritoRepository : IDetalleCarritoRepository
    {
        private readonly adidasEntities _context;

        public DetalleCarritoRepository()
        {
            _context = new adidasEntities();
        }

        public IEnumerable<DetalleCarrito> GetDetalles()
        {
            return _context.DetalleCarrito.ToList();
        }

        public DetalleCarrito GetDetalle(int id)
        {
            return _context.DetalleCarrito.Find(id);
        }

        public void AddDetalle(DetalleCarrito detalle)
        {
            _context.DetalleCarrito.Add(detalle);
            _context.SaveChanges();
        }

        public void UpdateDetalle(DetalleCarrito detalle)
        {
            _context.Entry(detalle).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteDetalle(int id)
        {
            var detalle = _context.DetalleCarrito.Find(id);
            if (detalle != null)
            {
                _context.DetalleCarrito.Remove(detalle);
                _context.SaveChanges();
            }
        }
    }
}