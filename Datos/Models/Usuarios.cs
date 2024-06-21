using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public partial class Usuarios
    {
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string email_usuario { get; set; }
        public string password_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public Nullable<System.DateTime> registro_fecha { get; set; }
        public string genero_usuario { get; set; }
    }
}
