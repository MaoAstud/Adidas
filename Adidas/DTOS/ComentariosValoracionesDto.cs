using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class ComentariosValoracionesDto
    {
        public int IdComentario { get; set; }
        public int? UsuarioId { get; set; }
        public int? ProductoId { get; set; }
        public string ComentarioTexto { get; set; }
        public int? Rating { get; set; }
        public DateTime? ComentarioFecha { get; set; }
    }
}