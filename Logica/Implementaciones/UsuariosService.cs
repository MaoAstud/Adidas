using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Interfaces;
using Datos;
using Logica.Interfaces;

namespace Logica.Implementaciones
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;

        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public IEnumerable<Usuarios> GetUsuarios()
        {
            return _usuariosRepository.GetUsuarios();
        }

        public Usuarios GetUsuario(int id)
        {
            return _usuariosRepository.GetUsuario(id);
        }

        public void AddUsuario(Usuarios usuario)
        {
            _usuariosRepository.AddUsuario(usuario);
        }

        public void UpdateUsuario(Usuarios usuario)
        {
            _usuariosRepository.UpdateUsuario(usuario);
        }

        public void DeleteUsuario(int id)
        {
            _usuariosRepository.DeleteUsuario(id);
        }
    }
}
