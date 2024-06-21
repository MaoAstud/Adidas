using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class CarritoComprasDto
    {
        public int IdCarrito { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? CreacionFecha { get; set; }
        public string SessionId { get; set; }
    }
}