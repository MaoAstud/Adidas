using AccesoDatos.Interfaces;
using AccesoDatos;
using Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Implementaciones
{
    public class ComentariosValoracionesService : IComentariosValoracionesService
    {
        private readonly IComentariosValoracionesRepository _comentariosValoracionesRepository;

        public ComentariosValoracionesService(IComentariosValoracionesRepository comentariosValoracionesRepository)
        {
            _comentariosValoracionesRepository = comentariosValoracionesRepository;
        }

        public IEnumerable<ComentariosValoraciones> GetComentariosValoraciones()
        {
            return _comentariosValoracionesRepository.GetComentariosValoraciones();
        }

        public ComentariosValoraciones GetComentarioValoracion(int id)
        {
            return _comentariosValoracionesRepository.GetComentarioValoracion(id);
        }

        public void AddComentarioValoracion(ComentariosValoraciones comentario)
        {
            _comentariosValoracionesRepository.AddComentarioValoracion(comentario);
        }

        public void UpdateComentarioValoracion(ComentariosValoraciones comentario)
        {
            _comentariosValoracionesRepository.UpdateComentarioValoracion(comentario);
        }

        public void DeleteComentarioValoracion(int id)
        {
            _comentariosValoracionesRepository.DeleteComentarioValoracion(id);
        }
    }
}
