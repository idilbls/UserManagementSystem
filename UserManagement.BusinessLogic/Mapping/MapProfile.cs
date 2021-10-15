using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.Models.Entities.Users;
using UserManagement.Shared.DTOs.Users;

namespace UserManagement.BusinessLogic.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
