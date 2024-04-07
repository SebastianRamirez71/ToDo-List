using AutoMapper;
using ToDoList.Mappings;
using ToDoList.Models;
using ToDoList.Models.DTOs;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ToDoListDBContext _context;
        private readonly IMapper _mapper;
        public TodoItemService(ToDoListDBContext context)
        {
            _context = context;
            _mapper = AutoMapperConfig.Configure();
        }

        public ToDoDTO AgregarToDo(ToDoDTO ToDo)
        {
            var res = new TodoItems()
            {
                Title = ToDo.Title,
                IdUser = ToDo.IdUser,
                Description = ToDo.Description
            };
            _context.TodoItems.Add(res);
            _context.SaveChanges();
            return ToDo;
        }

        public bool EliminarToDo(int id)
        {
            var removeToDo = _context.TodoItems.FirstOrDefault(x => x.IdTodo == id);
            _context.TodoItems.Remove(removeToDo);
            _context.SaveChanges();
            return true;
        }

        public List<ToDoDTO> ObtenerToDos()
        {
            return _mapper.Map<List<ToDoDTO>>(_context.TodoItems.ToList());
        }
    }
}
