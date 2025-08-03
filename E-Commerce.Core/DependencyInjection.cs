using E_Commerce.Core.ServiceContracts.Interfaces.UserSerice;
using E_Commerce.Core.Services.Implementations.UserService;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using E_Commerce.Core.Validators;
namespace E_Commerce.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
            return services;
        }
    }
}
