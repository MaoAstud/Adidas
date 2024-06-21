//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentariosValoraciones> ComentariosValoraciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCarrito> DetalleCarrito { get; set; }
    }
}
