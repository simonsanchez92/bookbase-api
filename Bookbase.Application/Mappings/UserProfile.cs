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

            CreateMap<Book, BookResponseDto>()
                    .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.BookGenres.Select(bg => bg.Genre).ToList()));

            CreateMap<CreateBookDto, Book>();

            CreateMap<Genre, GenreResponseDto>();

            CreateMap<CreateUserBookDto, UserBook>();

            CreateMap<UserBook, ShelfBookResponseDto>();

            CreateMap<GenericListResponse<Book>, GenericListResponse<BookResponseDto>>();

            CreateMap<UserBook, UserBookResponseDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Book.Id))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Book.Title))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Book.Author))
            .ForMember(dest => dest.PublishYear, opt => opt.MapFrom(src => src.Book.PublishYear))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Book.Description))
            .ForMember(dest => dest.CoverUrl, opt => opt.MapFrom(src => src.Book.CoverUrl))
            .ForMember(dest => dest.PageCount, opt => opt.MapFrom(src => src.Book.PageCount))
            .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.Book.BookGenres.Select(bg => new GenreResponseDto
            {
                Id = bg.Genre.Id,
                Name = bg.Genre.Name,
            }).ToList()));


            CreateMap<GenericListResponse<UserBook>, GenericListResponse<UserBookResponseDto>>()
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));


        }
    }
}
