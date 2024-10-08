using Bookbase.Application.Interfaces;
using Bookbase.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bookbase.Application.Extensions
{
    public static class ApplicationExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IBookService, BookService>();
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<ICommentService, CommentService>();



            return services;
        }
    }
}
