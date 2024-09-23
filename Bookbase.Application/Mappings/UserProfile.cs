﻿using AutoMapper;
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

            CreateMap<Book, BookResponseDto>()
                    .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.BookGenres.Select(bg => bg.Genre).ToList()));

            CreateMap<CreateBookDto, Book>();
            //.ForMember(dest => dest.BookGenres, opt => opt.Ignore());

            CreateMap<Genre, GenreResponseDto>();


            CreateMap<CreateUserBookDto, UserBook>();

            CreateMap<UserBook, UserBookResponseDto>();

            CreateMap<UserBook, UserBookListResponseDto>();

            CreateMap<UserBook, ShelfBookResponseDto>();
            //        .ForMember(dest => dest.Book, opt => opt.MapFrom(src => src.Book))
            //        .ForPath(dest => dest.Book.Genres, opt => opt.Ignore());
            //}
        }
    }
}
