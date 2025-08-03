

using E_Commerce.Core.RepositoryContracts.Interfaces.UserRepo;
using E_Commerce.Infrastructure.DbContexte;
using E_Commerce.Infrastructure.Repositories.Implementations.UserRepo;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<DapperDbContext>();
            return services;
        }
    }
}
