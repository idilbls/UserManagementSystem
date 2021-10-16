using Microsoft.EntityFrameworkCore;
using UserManagement.Models.Entities.Users;

namespace UserManagement.Core.Context
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
