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
            CreateMap<CreateBookDto, Book>();
            CreateMap<Book, UserBookResponseDto>();
            CreateMap<BookResponse, BookListResponseDto>();
            CreateMap<ReadingStatus, ReadingStatusResponseDto>();
            CreateMap<Genre, GenreResponseDto>();
            CreateMap<ShelveBookDto, UserBook>();
            CreateMap<GenericListResponse<BookResponse>, GenericListResponse<BookListResponseDto>>();
            CreateMap<Comment, CommentDto>(); //What is this?
            CreateMap<Like, LikeDto>();

            CreateMap<GenericListResponse<Book>, GenericListResponse<BookResponseDto>>();
            CreateMap<GenericListResponse<Comment>, GenericListResponse<CommentResponseDto>>();

            CreateMap<Review, CreateReviewResponseDto>();
            CreateMap<Review, ReviewResponseDto>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username));

            CreateMap<Comment, CommentResponseDto>()
                    .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.Username));

            CreateMap<BookGenre, GenreResponseDto>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Genre.Id))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Genre.Name));

            CreateMap<Book, BookResponseDto>()
                    .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.BookGenres.Select(bg => bg.Genre).ToList()));

            CreateMap<UserBook, UserBookResponseDto>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => new ReadingStatusResponseDto
                {
                    Id = src.ReadingStatus.Id,
                    Name = src.ReadingStatus.Name,
                }));


            CreateMap<GenericListResponse<UserBook>, GenericListResponse<UserBookResponseDto>>()
                .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data));






        }
    }
}
