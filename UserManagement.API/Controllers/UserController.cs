using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.BusinessLogic.Abstract;
using UserManagement.Shared.DTOs.Users;

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("get_all")]
        public async Task<IList<UserDto>> GetAllUsers()
        {
            return await _userService.GetAllUsersAsync();
            
        }

        [HttpPost("get_user_by_id")]
        public async Task<UserDto> GetUserById(int id)
        {
            return await _userService.GetUserByIdAsync(id);
        }

        [HttpPost("add")]
        public async Task<UserDto> AddUser(UserDto user)
        {
            return await _userService.AddUserAsync(user);
        }

        [HttpPost("update")]
        public async Task<UserDto> Update(UserDto user)
        {
            return await _userService.UpdateAsync(user);
        }

        [HttpDelete("delete")]
        public async Task<bool> DeleteAsync(int id)
        {
            return await _userService.DeleteAsync(id);
        }
    }
}
