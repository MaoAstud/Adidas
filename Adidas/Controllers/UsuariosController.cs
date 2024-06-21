using System.Collections.Generic;
using System.Web.Http;
using Logica.Interfaces;
using Datos;
using AccesoDatos;
using AccesoDatos.Repositories;
using AccesoDatos.Repositorios;
using Logica.Implementaciones;
using Adidas.DTOS;
using System.Linq;

namespace AdidasApi.Controllers
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuariosService _usuariosService;

        // Constructor sin parámetros para Web API
        public UsuariosController()
        {
            var usuariosRepository = new UsuariosRepository();
            _usuariosService = new UsuariosService(usuariosRepository);
        }

        // Constructor para inyección de dependencias (opcional)
        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        // GET: api/usuarios
        [HttpGet]
        public IEnumerable<UsuarioDto> GetUsuarios()
        {
            var usuarios = _usuariosService.GetUsuarios();
            return usuarios.Select(u => new UsuarioDto
            {
                IdUsuario = u.id_usuario,
                NombreUsuario = u.nombre_usuario,
                EmailUsuario = u.email_usuario,
                PasswordUsuario = u.password_usuario,
                TelefonoUsuario = u.telefono_usuario,
                DireccionUsuario = u.direccion_usuario,
                RegistroFecha = u.registro_fecha,
                GeneroUsuario = u.genero_usuario
            }).ToList();
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

            var usuarioDto = new UsuarioDto
            {
                IdUsuario = usuario.id_usuario,
                NombreUsuario = usuario.nombre_usuario,
                EmailUsuario = usuario.email_usuario,
                PasswordUsuario = usuario.password_usuario,
                TelefonoUsuario = usuario.telefono_usuario,
                DireccionUsuario = usuario.direccion_usuario,
                RegistroFecha = usuario.registro_fecha,
                GeneroUsuario = usuario.genero_usuario
            };

            return Ok(usuarioDto);
        }

        // POST: api/usuarios
        [HttpPost]
        public IHttpActionResult PostUsuario(UsuarioDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var usuario = new Usuarios
            {
                nombre_usuario = usuarioDto.NombreUsuario,
                email_usuario = usuarioDto.EmailUsuario,
                password_usuario = usuarioDto.PasswordUsuario,
                telefono_usuario = usuarioDto.TelefonoUsuario,
                direccion_usuario = usuarioDto.DireccionUsuario,
                registro_fecha = usuarioDto.RegistroFecha,
                genero_usuario = usuarioDto.GeneroUsuario
            };

            _usuariosService.AddUsuario(usuario);

            return CreatedAtRoute("DefaultApi", new { id = usuario.id_usuario }, usuarioDto);
        }

        // PUT: api/usuarios/5
        [HttpPut]
        public IHttpActionResult PutUsuario(int id, UsuarioDto usuarioDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuarioDto.IdUsuario)
            {
                return BadRequest();
            }

            var usuario = new Usuarios
            {
                id_usuario = usuarioDto.IdUsuario,
                nombre_usuario = usuarioDto.NombreUsuario,
                email_usuario = usuarioDto.EmailUsuario,
                password_usuario = usuarioDto.PasswordUsuario,
                telefono_usuario = usuarioDto.TelefonoUsuario,
                direccion_usuario = usuarioDto.DireccionUsuario,
                registro_fecha = usuarioDto.RegistroFecha,
                genero_usuario = usuarioDto.GeneroUsuario
            };

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

            return Ok();
        }
    }
}
