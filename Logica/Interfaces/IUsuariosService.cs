using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
    public interface IUsuariosService
    {
        IEnumerable<Usuarios> GetUsuarios();
        Usuarios GetUsuario(int id);
        void AddUsuario(Usuarios usuario);
        void UpdateUsuario(Usuarios usuario);
        void DeleteUsuario(int id);
    }
}
