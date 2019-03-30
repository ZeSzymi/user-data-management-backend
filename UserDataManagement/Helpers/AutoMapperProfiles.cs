using AutoMapper;
using userDataManagement.Dtos;
using userDataManagement.ModelsDb;

namespace userDataManagement.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDb, UserDto>();
            CreateMap<UserDto, UserDb>();
        }
    }
}
