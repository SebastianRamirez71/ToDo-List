using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models.DTOs;
using ToDoList.Services;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController : ControllerBase
    {
        private readonly ITodoItemService _service;
        public ToDoItemController(ITodoItemService service)
        {
            _service = service;
        }

        [HttpPost("tarea")]
        public IActionResult AgregarToDo([FromBody] ToDoDTO todo)
        {
            var newToDo = _service.AgregarToDo(todo);
            return StatusCode(StatusCodes.Status201Created, newToDo);

        }

        [HttpGet("tareas")]
        public IActionResult ObtenerToDos()
        {
            return Ok(_service.ObtenerToDos());
        }

        [HttpDelete("tareas/{id}")]
        public IActionResult EliminarToDo(int id)
        {
            _service.EliminarToDo(id);
            return Ok();
        }
    }
}
