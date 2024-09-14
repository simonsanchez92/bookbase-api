using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Mappings
{
    public class BookProfile : Profile
    {

        public BookProfile()
        {
            CreateMap<Book, BookResponseDto>();

            CreateMap<CreateBookDto, Book>()
                .ForMember(dest => dest.BookGenres, opt => opt.Ignore());
        }

    }
}
