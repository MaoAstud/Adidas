using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class CategoriaDto
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? PadreId { get; set; }
    }
}