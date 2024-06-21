using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class DetalleCarrito
    {
        public int id_detalle { get; set; }
        public Nullable<int> carrito_id { get; set; }
        public Nullable<int> producto_id { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<System.DateTime> agregado_fecha { get; set; }

        public virtual CarritoCompras CarritoCompras { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
