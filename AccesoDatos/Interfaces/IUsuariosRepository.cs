using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IUsuariosRepository
    {
        IEnumerable<Usuarios> GetUsuarios();
        Usuarios GetUsuario(int id);
        void AddUsuario(Usuarios usuario);
        void UpdateUsuario(Usuarios usuario);
        void DeleteUsuario(int id);
    }
}
