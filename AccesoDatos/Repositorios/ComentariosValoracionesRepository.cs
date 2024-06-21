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
    public class ComentariosValoracionesRepository : IComentariosValoracionesRepository
    {
        private readonly adidasEntities _context;

        public ComentariosValoracionesRepository()
        {
            _context = new adidasEntities();
        }

        public IEnumerable<ComentariosValoraciones> GetComentariosValoraciones()
        {
            return _context.ComentariosValoraciones.ToList();
        }

        public ComentariosValoraciones GetComentarioValoracion(int id)
        {
            return _context.ComentariosValoraciones.Find(id);
        }

        public void AddComentarioValoracion(ComentariosValoraciones comentario)
        {
            _context.ComentariosValoraciones.Add(comentario);
            _context.SaveChanges();
        }

        public void UpdateComentarioValoracion(ComentariosValoraciones comentario)
        {
            _context.Entry(comentario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteComentarioValoracion(int id)
        {
            var comentario = _context.ComentariosValoraciones.Find(id);
            if (comentario != null)
            {
                _context.ComentariosValoraciones.Remove(comentario);
                _context.SaveChanges();
            }
        }
    }
}
