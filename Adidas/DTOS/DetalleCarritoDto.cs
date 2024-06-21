using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class DetalleCarritoDto
    {
        public int IdDetalle { get; set; }
        public int? CarritoId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? AgregadoFecha { get; set; }
    }
}