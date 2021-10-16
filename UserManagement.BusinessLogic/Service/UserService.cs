using Abp.UI;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.BusinessLogic.Abstract;
using UserManagement.Core.Context;
using UserManagement.Models.Entities.Users;
using UserManagement.Models.Errors;
using UserManagement.Shared.DTOs.Users;

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

        public async Task<UserDto> AddUserAsync(UserDto user)
        {
            try
            {
                var mappedUser = _mapper.Map<User>(user);
                await _context.Users.AddAsync(mappedUser);
                await _context.SaveChangesAsync();

                return _mapper.Map<UserDto>(mappedUser);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound, ex.Message);
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(c => c.Id == id);
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound, ex.Message);
            }

        }

        public async Task<IList<UserDto>> GetAllUsersAsync()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                return _mapper.Map<List<UserDto>>(users);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.UsersNotFound, ErrorMessages.UsersNotFound, ex.Message);
            }
        }

        public async Task<UserDto> GetUserByIdAsync(int id)
        {
            try
            {
                var user = await _context.Users.FindAsync(id);
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound, ex.Message);
            }
        }

        public async Task<UserDto> UpdateAsync(UserDto user)
        {
            try
            {
                var mappedUser = _mapper.Map<User>(user);
                var userResult = await _context.Users.FindAsync(mappedUser.Id);

                userResult.Name = user.Name;
                userResult.Surname = user.Surname;
                userResult.PhoneNumber = user.PhoneNumber;
                userResult.Email = user.Email;
                userResult.DateOfBirth = user.DateOfBirth;

                _context.Users.Update(userResult);
                await _context.SaveChangesAsync();
                return _mapper.Map<UserDto>(userResult);
            }
            catch (Exception ex)
            {

                throw new UserFriendlyException((int)ErrorCodes.UserNotFound, ErrorMessages.UserNotFound, ex.Message);
            }

        }
    }
}
