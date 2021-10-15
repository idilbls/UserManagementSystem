using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.BusinessLogic.Abstract;
using UserManagement.Core.Context;

namespace UserManagement.BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private readonly UserManagementDbContext _context;
        private readonly IMapper _mapper;

        public UserService(UserManagementDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
