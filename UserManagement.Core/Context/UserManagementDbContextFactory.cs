using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UserManagement.Core.Context
{
    public class UserManagementDbContextFactory : IDesignTimeDbContextFactory<UserManagementDbContext>
    {
        public UserManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UserManagementDbContext>();
            var connectionString = "Server=DESKTOP-2807U0Q\\SQLEXPRESS; Database=UserManagementDb; Integrated Security=True; MultipleActiveResultSets=True";
            builder.UseSqlServer(connectionString);
            return new UserManagementDbContext(builder.Options);
        }
    }
}
