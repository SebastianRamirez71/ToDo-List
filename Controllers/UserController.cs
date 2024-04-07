using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ToDoList.Models.DTOs;
using ToDoList.Services;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("AgregarUsuario")]
        public IActionResult AgregarUsuario([FromBody] UserDTO user)
        {
            var newUser = _service.AgregarUsuario(user);
            return StatusCode(StatusCodes.Status201Created, newUser);
        }

        [HttpGet("Usuarios")]
        public IActionResult ObtenerUsuarios()
        {
            return Ok(_service.ObtenerUsuarios());
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            _service.EliminarUsuario(id);
            return Ok();
        }
    }
}
