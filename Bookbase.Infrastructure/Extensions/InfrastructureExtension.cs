using Bookbase.Domain.Interfaces;
using Bookbase.Infrastructure.Repositories;
using Bookbase.Infrastructure.Services;
using Bookbase.Infrastructure.Validators;
using Microsoft.Extensions.DependencyInjection;

namespace Bookbase.Infrastructure.Extensions
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddSingleton<IPasswordEncryptionService, PasswordEncryptionService>();
            services.AddSingleton<IJwtTokenService, JwtTokenService>();
            
            services.AddTransient<IUserCreateValidatorService, UserCreateValidatorService>();



            return services;
        }
    }
}
