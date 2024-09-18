using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Mappings
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<User, UserResponseDto>();
            CreateMap<Book, BookResponseDto>();

            CreateMap<CreateBookDto, Book>()
                .ForMember(dest => dest.BookGenres, opt => opt.Ignore());

            CreateMap<Genre, GenreResponseDto>();
        }
    }
}
