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
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;


        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }


        public async Task<GenericListResponse<BookListResponseDto>> GetList(int? userId, int page, int pageSize, string? query)
        {
            var books = await _bookRepository.GetList(userId, page, pageSize, query);


            return _mapper.Map<GenericListResponse<BookListResponseDto>>(books);
        }


        public async Task<BookListResponseDto?> GetOne(int? userId, int bookId)
        {
            var book = await _bookRepository.GetOne(userId, bookId);

            if (book == null)
            {
                throw new NotFoundException("Book not found")
                {
                    ErrorCode = "003"
                };
            }

            return _mapper.Map<BookListResponseDto>(book);
        }


        public async Task<GenericResult<BookResponseDto>> Create(CreateBookDto bookDto)
        {
            //Converting DTO into Book entity
            var newBook = _mapper.Map<Book>(bookDto);

            var createdBook = await _bookRepository.Create(newBook, bookDto.GenreIds);

            var data = _mapper.Map<BookResponseDto>(createdBook);

            return GenericResult<BookResponseDto>.SuccessResult(data);
        }

        public async Task<BookResponseDto> Update(int bookId, UpdateBookDto bookDto)
        {
            var currentBook = await _bookRepository.GetOne(null, bookId);

            if (currentBook == null)
            {
                throw new BadRequestException($"No book found with id {bookId}")
                {
                    ErrorCode = "005"
                };

            }

            currentBook.Book.Description = bookDto.Description;
            currentBook.Book.CoverUrl = bookDto.CoverUrl;

            var updatedBook = await _bookRepository.Update(currentBook.Book);

            return _mapper.Map<BookResponseDto>(updatedBook);
        }


        public async Task<BookListResponseDto> ShelveBook(int? userId, int bookId)
        {

            var isShelved = await _bookRepository.GetOne(userId, bookId);

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

            var shelvedBook = await _bookRepository.Shelve(userBook);


            return _mapper.Map<BookListResponseDto>(shelvedBook);
        }

        public async Task<UserBookResponseDto> UpsertUserBook(int userId, int bookId, Action<UserBook> updateField)
        {
            var bookResponse = await _bookRepository.GetOne(userId, bookId);

            //Fix exception handling!
            //
            //
            if (bookResponse == null)
            {
                throw new BadRequestException($"Book of id {bookId} does not exist")
                {
                    ErrorCode = "009"
                };
            }

            if (bookResponse.UserBook == null)
            {
                bookResponse.UserBook = new UserBook
                {
                    UserId = userId,
                    BookId = bookId,
                    ReadingStatusId = (int)ReadingStatusEnum.WantToRead
                };

                await _bookRepository.Shelve(bookResponse.UserBook);
            }

            //Apply the specific updates from the delegate
            updateField(bookResponse.UserBook);

            //Update the existing userBook entity in the repository
            var updatedUserBook = await _bookRepository.UpdateUserBook(bookResponse.UserBook);

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


        public Task<bool> Delete(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveFromShelf(int userId, int bookId)
        {
            var bookResponse = await _bookRepository.GetOne(userId, bookId);

            if (bookResponse == null)
            {
                throw new BadRequestException($"Book of id {bookId} does not exist")
                {
                    ErrorCode = "008"
                };
            }

            if (bookResponse.UserBook == null)
            {
                throw new BadRequestException($"Bad request")
                {
                    ErrorCode = "005"
                };

            }
            await _bookRepository.RemoveFromShelf(bookResponse.UserBook);

            return true;
        }

        public async Task<GenericListResponse<BookListResponseDto>> GetUserShelf(int userId, int page, int pageSize)
        {
            var books = await _bookRepository.GetUserShelf(userId, page, pageSize);


            return _mapper.Map<GenericListResponse<BookListResponseDto>>(books);
        }

        public async Task<IEnumerable<BookListResponseDto>> GetAll(int? userId)
        {

            var results = await _bookRepository.GetAllWithIncludes(userId);

            return _mapper.Map<IEnumerable<BookListResponseDto>>(results);

        }
    }
}
