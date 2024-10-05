using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Common;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Mappings
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<User, UserResponseDto>();


            CreateMap<BookGenre, GenreResponseDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Genre.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Book, BookResponseDto>()
                    .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.BookGenres.Select(bg => bg.Genre).ToList()));

            // Explicitly map from Book to UserBookResponseDto (inherits from BookResponseDto)
            CreateMap<Book, UserBookResponseDto>();
            //.IncludeBase<Book, BookResponseDto>(); // Inherit properties from BookResponseDto

            CreateMap<BookResponse, BookListResponseDto>();


            CreateMap<UserBook, UserBookResponseDto>();
            //.IncludeMembers(src => src.Book) // Include properties from the related Book entity
            //.ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.Book.BookGenres)); // Map genres from BookGenres

            CreateMap<CreateBookDto, Book>();

            CreateMap<Genre, GenreResponseDto>();

            CreateMap<ShelveBookDto, UserBook>();

            CreateMap<GenericListResponse<Book>, GenericListResponse<BookResponseDto>>();

            CreateMap<GenericListResponse<UserBook>, GenericListResponse<UserBookResponseDto>>()
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));


            CreateMap<GenericListResponse<BookResponse>, GenericListResponse<BookListResponseDto>>();

        }
    }
}
