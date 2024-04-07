using ToDoList.Models.DTOs;

namespace ToDoList.Services.Interfaces
{
    public interface ITodoItemService
    {
        public ToDoDTO AgregarToDo(ToDoDTO ToDo);
        public List<ToDoDTO> ObtenerToDos();
        public bool EliminarToDo(int id);

    }
}
