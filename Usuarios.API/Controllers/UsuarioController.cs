using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Usuarios.BI.Data;
using Usuarios.Entities.Entities;

namespace Usuarios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Context contextapp;
        public UsuarioController(Context context)
        {
            this.contextapp = context;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return contextapp.Usuario.ToList();
        }
    }
}
