using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public string DireccionUsuario { get; set; }
        public DateTime? RegistroFecha { get; set; }
        public string GeneroUsuario { get; set; }
    }
}