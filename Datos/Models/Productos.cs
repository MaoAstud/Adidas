using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class Productos
    {
        public Productos()
        {
            this.ComentariosValoraciones = new HashSet<ComentariosValoraciones>();
            this.DetalleCarrito = new HashSet<DetalleCarrito>();
        }

        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> categoria_id { get; set; }
        public string talla { get; set; }
        public string color { get; set; }
        public string material { get; set; }
        public string imagen { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public Nullable<decimal> peso_producto { get; set; }

        public virtual Categorias Categorias { get; set; }
        public virtual ICollection<ComentariosValoraciones> ComentariosValoraciones { get; set; }
        public virtual ICollection<DetalleCarrito> DetalleCarrito { get; set; }
    }
}
