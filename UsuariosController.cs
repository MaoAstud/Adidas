using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Logica.Implementations;
using Datos.Models;
using AccesoDatos.Repositories;

namespace AdidasApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController()
        {
            // Inicializar el repositorio y el servicio
            IUsuariosRepository usuariosRepository = new UsuariosRepository();
            _usuariosService = new UsuariosService(usuariosRepository);
        }

        // GET: api/usuarios
        [HttpGet]
        public IEnumerable<Usuarios> GetUsuarios()
        {
            return _usuariosService.GetUsuarios();
        }

        // GET: api/usuarios/5
        [HttpGet]
        public IHttpActionResult GetUsuario(int id)
        {
            var usuario = _usuariosService.GetUsuario(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // POST: api/usuarios
        [HttpPost]
        public IHttpActionResult PostUsuario(Usuarios usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _usuariosService.AddUsuario(usuario);

            return CreatedAtRoute("DefaultApi", new { id = usuario.id_usuario }, usuario);
        }

        // PUT: api/usuarios/5
        [HttpPut]
        public IHttpActionResult PutUsuario(int id, Usuarios usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.id_usuario)
            {
                return BadRequest();
            }

            _usuariosService.UpdateUsuario(usuario);

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/usuarios/5
        [HttpDelete]
        public IHttpActionResult DeleteUsuario(int id)
        {
            var usuario = _usuariosService.GetUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _usuariosService.DeleteUsuario(id);

            return Ok(usuario);
        }
    }
}

