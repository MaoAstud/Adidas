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
    public class CategoriasRepository : ICategoriasRepository
    {
        private readonly adidasEntities _context;

        public CategoriasRepository()
        {
            _context = new adidasEntities();
        }

        public IEnumerable<Categorias> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categorias GetCategoria(int id)
        {
            return _context.Categorias.Find(id);
        }

        public void AddCategoria(Categorias categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void UpdateCategoria(Categorias categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCategoria(int id)
        {
            var categoria = _context.Categorias.Find(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
            }
        }
    }
}

