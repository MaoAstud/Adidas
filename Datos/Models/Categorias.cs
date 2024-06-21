namespace Datos.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Categorias
    {
        public Categorias()
        {
            this.Categorias1 = new HashSet<Categorias>();
            this.Productos = new HashSet<Productos>();
        }

        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> padre_id { get; set; }

        public virtual ICollection<Categorias> Categorias1 { get; set; }
        public virtual Categorias Categorias2 { get; set; }
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
