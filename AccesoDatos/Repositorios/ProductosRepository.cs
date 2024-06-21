using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AccesoDatos.Interfaces;
using AccesoDatos;
using System.Data.Entity;
using System.Linq;

namespace AccesoDatos.Repositories
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly adidasEntities _context;

        public ProductosRepository()
        {
            _context = new adidasEntities();
        }

        public IEnumerable<Productos> GetProductos()
        {
            return _context.Productos.ToList();
        }

        public Productos GetProducto(int id)
        {
            return _context.Productos.Find(id);
        }

        public void AddProducto(Productos producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void UpdateProducto(Productos producto)
        {
            _context.Entry(producto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteProducto(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}

