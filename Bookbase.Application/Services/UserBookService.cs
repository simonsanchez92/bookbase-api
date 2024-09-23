﻿using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Common;
using Bookbase.Domain.Interfaces;

namespace Bookbase.Application.Services
{
    public class UserBookService : IUserBookService
    {
        private readonly IUserBookRepository _userBookRepository;
        private readonly IMapper _mapper;

        public UserBookService(IUserBookRepository userBookRepository, IMapper mapper)
        {
            _userBookRepository = userBookRepository;
            _mapper = mapper;
        }

        public async Task<UserBookResponseDto> Add(int userId, int bookId)
        {
            var userBook = await _userBookRepository.Add(userId, bookId);

            if (userBook == null)
            {

                throw new BadRequestException()
                {
                    ErrorCode = "005"
                };
            }
            return _mapper.Map<UserBookResponseDto>(userBook);
        }

        public async Task<UserBookResponseDto?> GetOne(int userId, int bookId)
        {
            var userBook = await _userBookRepository.GetOne(userId, bookId);

            if (userBook == null)
            {
                throw new NotFoundException($"No user-book found with ids of user id:{userId} - book id: {bookId}")
                {
                    ErrorCode = "004"
                };
            }

            return _mapper.Map<UserBookResponseDto>(userBook);
        }

        public async Task<UserBookListResponseDto> Update(int userId, int bookId, UpdateUserBookDto userBookDto)
        {
            var currentUB = await _userBookRepository.GetOne(userId, bookId);

            if (currentUB == null)
            {
                throw new BadRequestException($"No book found with id {bookId}")
                {
                    ErrorCode = "005"
                };

            }

            currentUB.Status = userBookDto.Status.ToString();

            var updatedUserBook = await _userBookRepository.Update(currentUB);

            return _mapper.Map<UserBookListResponseDto>(updatedUserBook);
        }


        public async Task<bool> Delete(int userId, int bookId)
        {
            var userBook = await _userBookRepository.GetOne(userId, bookId);

            if (userBook == null)
            {
                throw new BadRequestException($"Bad request")
                {
                    ErrorCode = "005"
                };

            }

            await _userBookRepository.Delete(userBook);

            return true;
        }

        //public async Task<UserWithBooksResponseDto> GetAll(int userId)
        //{
        //    var ubooks = await _userBookRepository.GetAll(userId);

        //    var books = ubooks.Select(ub => new BookResponse
        //    {
        //        BookId = ub.BookId,
        //        Status = ub.Status,
        //    });

        //    var userBooks = new UserWithBooksResponseDto
        //    {
        //        UserId = userId,
        //        Books = books
        //    };

        //    return userBooks;
        //    //return _mapper.Map<IEnumerable<UserWithBooksResponseDto>>(userBooks);
        //}

        public async Task<UserBookListResponseDto> GetList(int userId)
        {
            //Retrieves joined tables UserBook and Book
            var userBooks = await _userBookRepository.GetList(userId);

            var books = userBooks.Select(ub => new BookResponse
            {
                BookId = ub.Book.Id,
                CoverUrl = ub.Book.CoverUrl,
                Title = ub.Book.Title,
                Author = ub.Book.Author,
                Status = ub.Status
            }).ToList();

            var userBooksDto = new UserBookListResponseDto
            {
                Books = books
            };

            return userBooksDto;
        }
    }
}
