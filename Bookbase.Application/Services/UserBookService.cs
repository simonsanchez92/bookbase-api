using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Common;
using Bookbase.Domain.Enums;
using Bookbase.Domain.Interfaces;
using Bookbase.Domain.Models;

namespace Bookbase.Application.Services
{
    public class UserBookService : IUserBookService
    {
        private readonly IUserBookRepository _userBookRepository;
        private readonly IBookService _bookService;
        private readonly IMapper _mapper;

        public UserBookService(IUserBookRepository userBookRepository, IBookService bookService, IMapper mapper)
        {
            _userBookRepository = userBookRepository;
            _bookService = bookService;
            _mapper = mapper;
        }

        public async Task<BookListResponseDto> ShelveBook(int? userId, int bookId)
        {
            var isShelved = await _bookService.GetOne(userId, bookId);

            if (isShelved == null)
            {
                throw new BadRequestException($"Book with id {bookId} does not exist")
                {
                    ErrorCode = "006"
                };
            }

            if (isShelved.UserBook != null)
            {
                throw new BadRequestException("Book is already shelved")
                {
                    ErrorCode = "007"
                };
            }

            var userBook = new UserBook
            {
                UserId = (int)userId!,
                BookId = bookId,
                ReadingStatusId = (int)ReadingStatusEnum.WantToRead //default initial status
            };

            //var shelvedBook = await _bookRepository.Shelve(userBook);
            var shelvedBook = await _userBookRepository.Shelve(userBook);


            return _mapper.Map<BookListResponseDto>(shelvedBook);
        }

        public async Task<bool> RemoveFromShelf(int userId, int bookId)
        {
            var userBook = await _userBookRepository.GetOneUserBook(userId, bookId);

            if (userBook == null)
            {
                throw new BadRequestException($"Book of id {bookId} does not exist")
                {
                    ErrorCode = "008"
                };
            }
            //if (bookResponse == null)
            //{
            //    throw new BadRequestException($"Bad request")
            //    {
            //        ErrorCode = "005"
            //    };

            //}

            await _userBookRepository.RemoveFromShelf(userBook);

            return true;
        }


        public Task<GenericListResponse<BookListResponseDto>> GetUserShelf(int userId, int page, int pageSize)
        {
            //    var books = await _bookRepository.GetUserShelf(userId, page, pageSize);


            //    return _mapper.Map<GenericListResponse<BookListResponseDto>>(books);
            throw new NotImplementedException();
        }






        public async Task<UserBookResponseDto> UpsertUserBook(int userId, int bookId, Action<UserBook> updateField)
        {
            var userBook = await _userBookRepository.GetOneUserBook(userId, bookId);

            //Fix exception handling!
            //
            //
            //if (userBook == null)
            //{
            //    throw new BadRequestException($"Book of id {bookId} does not exist")
            //    {
            //        ErrorCode = "009"
            //    };
            //}

            if (userBook == null)
            {
                userBook = new UserBook
                {
                    UserId = userId,
                    BookId = bookId,
                    ReadingStatusId = (int)ReadingStatusEnum.WantToRead
                };

                await _userBookRepository.Shelve(userBook);
            }

            //Apply the specific updates from the delegate
            updateField(userBook);

            //Update the existing userBook entity in the repository
            var updatedUserBook = await _userBookRepository.UpdateUserBook(userBook);

            return _mapper.Map<UserBookResponseDto>(updatedUserBook);
        }


        public async Task<UserBookResponseDto> UpdateReadingStatus(int userId, int bookId, UpdateReadingStatusDto updateReadingStatusDto)
        {
            return await UpsertUserBook(userId, bookId, userBook =>
            {
                userBook.ReadingStatusId = (int)updateReadingStatusDto.Status;
                userBook.UpdatedAt = DateTime.UtcNow;
            });
        }


        public async Task<UserBookResponseDto> RateBook(int userId, int bookId, RateBookDto rateBookDto)
        {
            return await UpsertUserBook(userId, bookId, userBook =>
            {
                userBook.Rating = rateBookDto.Rating;
                userBook.ReadingStatusId = (int)ReadingStatusEnum.Read;
                userBook.UpdatedAt = DateTime.UtcNow;
            });
        }

    }
}
