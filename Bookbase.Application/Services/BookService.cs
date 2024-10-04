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


        public async Task<GenericListResponse<BookListResponseDto>> GetList(int? userId, int page, int pageSize)
        {
            var books = await _bookRepository.GetList(userId, page, pageSize);


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

        public async Task<ShelfBookResponseDto> ShelveBook(int? userId, int bookId)
        {
            var isShelved = await _bookRepository.GetOne(userId, bookId);


            if (userId == null)
            {
                throw new BadRequestException("User must be logged in")
                {
                    ErrorCode = "008"
                };
            }

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
                UserId = (int)userId,
                BookId = bookId,
                Status = ReadingStatus.WantToRead.ToString() //default initial status
            };

            await _bookRepository.Shelve(userBook);


            return _mapper.Map<ShelfBookResponseDto>(userBook);
        }



        public Task<bool> Delete(int bookId)
        {
            throw new NotImplementedException();
        }

    }
}
