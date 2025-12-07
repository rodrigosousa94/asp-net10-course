using aspnet10.Model.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace aspnet10.Configurations
{
    public static class DatabaseConfig
    {
        public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection string 'MSSQLServerSQLConnection:MSSQLServerSQLConnectionString' is not found in the configuration.");
            }

            services.AddDbContext<MSSQLContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
