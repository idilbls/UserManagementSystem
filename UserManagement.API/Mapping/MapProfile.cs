using AutoMapper;
using UserManagement.Models.Entities.Users;
using UserManagement.Shared.DTOs.Users;

namespace UserManagement.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
