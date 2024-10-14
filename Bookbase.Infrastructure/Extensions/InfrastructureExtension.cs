using Bookbase.Domain.Interfaces;
using Bookbase.Infrastructure.Repositories;
using Bookbase.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bookbase.Infrastructure.Extensions
{
    public static class InfrastructureExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            services.AddTransient<IUserBookRepository, UserBookRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<ILikeRepository, LikeRepository>();

            services.AddSingleton<IPasswordEncryptionService, PasswordEncryptionService>();
            services.AddSingleton<IJwtTokenService, JwtTokenService>();

            services.AddTransient<IUserCreateValidatorService, UserCreateValidatorService>();



            return services;
        }
    }
}
