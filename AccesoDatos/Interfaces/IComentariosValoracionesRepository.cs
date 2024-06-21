using System.Collections.Generic;
using AccesoDatos;

namespace AccesoDatos.Interfaces
{

    public interface IComentariosValoracionesRepository
    {
        IEnumerable<ComentariosValoraciones> GetComentariosValoraciones();
        ComentariosValoraciones GetComentarioValoracion(int id);
        void AddComentarioValoracion(ComentariosValoraciones comentario);
        void UpdateComentarioValoracion(ComentariosValoraciones comentario);
        void DeleteComentarioValoracion(int id);
    }
}
