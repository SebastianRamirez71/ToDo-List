using ToDoList.Models.DTOs;

namespace ToDoList.Services.Interfaces
{
    public interface IUserService
    {
        public UserDTO AgregarUsuario(UserDTO user);
        public List<UserDTO> ObtenerUsuarios();
        public bool EliminarUsuario(int id);
    }
}
