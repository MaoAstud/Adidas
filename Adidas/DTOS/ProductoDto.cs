using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.DTOS
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? CategoriaId { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Imagen { get; set; }
        public int? Stock { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public decimal? PesoProducto { get; set; }
    }
}