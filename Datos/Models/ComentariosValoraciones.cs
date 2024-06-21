using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class ComentariosValoraciones
    {
        public int id_comentario { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<int> producto_id { get; set; }
        public string comentario_texto { get; set; }
        public Nullable<int> rating { get; set; }
        public Nullable<System.DateTime> comentario_fecha { get; set; }

        public virtual Productos Productos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
