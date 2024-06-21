namespace Datos.Models
{
    using System;
    using System.Collections.Generic;

    public partial class CarritoCompras
    {
        public CarritoCompras()
        {
            this.DetalleCarrito = new HashSet<DetalleCarrito>();
        }

        public int id_carrito { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<System.DateTime> creacion_fecha { get; set; }
        public string session_id { get; set; }

        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<DetalleCarrito> DetalleCarrito { get; set; }
    }
}

