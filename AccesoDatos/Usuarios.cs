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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.CarritoCompras = new HashSet<CarritoCompras>();
            this.ComentariosValoraciones = new HashSet<ComentariosValoraciones>();
        }
    
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string email_usuario { get; set; }
        public string password_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public Nullable<System.DateTime> registro_fecha { get; set; }
        public string genero_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarritoCompras> CarritoCompras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentariosValoraciones> ComentariosValoraciones { get; set; }
    }
}
