using Bookbase.Validators;
using FluentValidation;

namespace Bookbase.Extensions
{
    public static class ValidatorsExtension
    {
        public static IServiceCollection AddCustomValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblyContaining<LoginValidator>();
            services.AddValidatorsFromAssemblyContaining<CreateUserValidator>();

            return services;
        }
    }
}
