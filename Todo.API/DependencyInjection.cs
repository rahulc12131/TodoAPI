using Microsoft.EntityFrameworkCore;
using Todo.Infrastructure.Persistance.Entities;

namespace Todo.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DbConnection");

            services.AddDbContext<TodoDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
