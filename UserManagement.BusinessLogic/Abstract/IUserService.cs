using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.Shared.DTOs.Users;

namespace UserManagement.BusinessLogic.Abstract
{
    public interface IUserService
    {
        Task<IList<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserByIdAsync(int id);
        Task<UserDto> AddUserAsync(UserDto user);
        Task<UserDto> UpdateAsync(UserDto user);
        Task<bool> DeleteAsync(int id);

    }
}
