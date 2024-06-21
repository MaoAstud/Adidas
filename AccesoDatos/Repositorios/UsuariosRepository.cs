using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;

namespace AccesoDatos.Repositorios
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly adidasEntities _context;

        public UsuariosRepository()
        {
            _context = new adidasEntities();
        }

        public IEnumerable<Usuarios> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public Usuarios GetUsuario(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void AddUsuario(Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void UpdateUsuario(Usuarios usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}