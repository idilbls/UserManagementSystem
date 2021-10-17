using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace UserManagement.Core.Context
{
    public class UserManagementDbContextFactory : IDesignTimeDbContextFactory<UserManagementDbContext>
    {

        private readonly IConfiguration config;
        public UserManagementDbContextFactory(IConfiguration _config)
        {
            config = _config;
        }
        public UserManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<UserManagementDbContext>();
            var connectionString = config["ConnectionStrings:Default"];
            builder.UseSqlServer(connectionString);
            return new UserManagementDbContext(builder.Options);
        }
    }
}
