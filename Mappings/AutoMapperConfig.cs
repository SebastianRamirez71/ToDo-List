using AutoMapper;

namespace ToDoList.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            return mapper;
        }
    }
}
