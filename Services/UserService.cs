using AutoMapper;
using ToDoList.Mappings;
using ToDoList.Models;
using ToDoList.Models.DTOs;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services
{
    public class UserService : IUserService
    {
        private readonly ToDoListDBContext _context;
        private readonly IMapper _mapper;
        public UserService(ToDoListDBContext context)
        {
              _context = context;
              _mapper = AutoMapperConfig.Configure();
        }

        public UserDTO AgregarUsuario(UserDTO user)
        {
            var userDto = new Users()
            {
                Email = user.Email,
                Name = user.Name,
                Address = user.Address,
            };
            _context.Users.Add(userDto);
            _context.SaveChanges();
            return user;
        }

        public bool EliminarUsuario(int id)
        {
            var removeUser = _context.Users.FirstOrDefault(x => x.IdUser == id);
            _context.Users.Remove(removeUser);
            _context.SaveChanges();
            return true;
        }

        public List<UserDTO> ObtenerUsuarios()
        {
            return _mapper.Map<List<UserDTO>>(_context.Users.ToList());
        }
    }
}
