using AutoMapper;
using ToDoList.Models;
using ToDoList.Models.DTOs;

namespace ToDoList.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<TodoItems, ToDoDTO>();
            CreateMap<Users, UserDTO>();
        } 
    }
}
