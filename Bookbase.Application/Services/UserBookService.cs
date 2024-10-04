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
        private readonly IMapper _mapper;

        public UserBookService(IUserBookRepository userBookRepository, IMapper mapper)
        {
            _userBookRepository = userBookRepository;
            _mapper = mapper;
        }

        public async Task<ShelfBookResponseDto> Add(int userId, int bookId)
        {
            var isShelved = await _userBookRepository.GetOne(userId, bookId);

            if (isShelved != null)
            {
                throw new BadRequestException("Book is already shelved")
                {
                    ErrorCode = "006"
                };
            }

            var userBook = new UserBook
            {
                UserId = userId,
                BookId = bookId,
                Status = ReadingStatus.WantToRead.ToString() //default initial status
            };

            await _userBookRepository.Shelve(userBook);


            return _mapper.Map<ShelfBookResponseDto>(userBook);
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

        //public async Task<IEnumerable<UserBookResponseDto>> GetList(int userId)
        //{
        //    //Retrieves joined tables UserBook and Book
        //    var userBooks = await _userBookRepository.GetList(userId);

        //    return _mapper.Map<IEnumerable<UserBookResponseDto>>(userBooks);
        //}

        public async Task<UserBookResponseDto> UpsertUserBook(int userId, int bookId, Action<UserBook> updateField)
        {
            var userBook = await _userBookRepository.GetOne(userId, bookId);

            if (userBook == null)
            {
                userBook = new UserBook
                {
                    UserId = userId,
                    BookId = bookId,
                    Status = ReadingStatus.WantToRead.ToString()
                };

                await _userBookRepository.Shelve(userBook);
            }

            //Apply the specific updates from the delegate
            updateField(userBook);

            //Update the existing userBook entity in the repository
            await _userBookRepository.Update(userBook);

            return _mapper.Map<UserBookResponseDto>(userBook);
        }


        public async Task<UserBookResponseDto> UpdateReadingStatus(int userId, int bookId, UpdateReadingStatusDto updateReadingStatusDto)
        {
            return await UpsertUserBook(userId, bookId, userBook =>
            {
                userBook.Status = updateReadingStatusDto.Status.ToString();
                userBook.UpdatedAt = DateTime.UtcNow;
            });
        }

        public async Task<UserBookResponseDto> Rate(int userId, int bookId, RateBookDto rateBookDto)
        {
            return await UpsertUserBook(userId, bookId, userBook =>
            {
                userBook.Rating = rateBookDto.Rating;
                userBook.Status = ReadingStatus.Read.ToString();
                userBook.UpdatedAt = DateTime.UtcNow;
            });
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

        public async Task<GenericListResponse<UserBookResponseDto>> GetList(int? userId, int page, int pageSize)
        {
            //Retrieves joined tables UserBook and Book
            var userBooks = await _userBookRepository.GetList(userId, page, pageSize);

            return _mapper.Map<GenericListResponse<UserBookResponseDto>>(userBooks);

        }
    }
}
