using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Interfaces
{
    public interface IComentariosValoracionesService
    {
        IEnumerable<ComentariosValoraciones> GetComentariosValoraciones();
        ComentariosValoraciones GetComentarioValoracion(int id);
        void AddComentarioValoracion(ComentariosValoraciones comentario);
        void UpdateComentarioValoracion(ComentariosValoraciones comentario);
        void DeleteComentarioValoracion(int id);
    }
}
