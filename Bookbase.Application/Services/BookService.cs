using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Common;
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


        public async Task<GenericListResponse<BookListResponseDto>> GetList(int userId, int page, int pageSize)
        {
            var books = await _bookRepository.GetList(userId, page, pageSize);

            //books.Data.Select(b => new
            //{
            //    Status = b.UserBooks.FirstOrDefault().Status,
            //});


            return _mapper.Map<GenericListResponse<BookListResponseDto>>(books);
        }


        public async Task<BookResponseDto?> GetOne(int bookId)
        {
            var book = await _bookRepository.GetOne(bookId);

            if (book == null)
            {
                throw new NotFoundException("Book not found")
                {
                    ErrorCode = "003"
                };
            }

            return _mapper.Map<BookResponseDto>(book);
        }


        public async Task<IEnumerable<BookResponseDto>> GetAll()
        {
            var books = await _bookRepository.GetAll();

            return _mapper.Map<IEnumerable<BookResponseDto>>(books);
        }


        public async Task<GenericResult<BookResponseDto>> Create(CreateBookDto bookDto)
        {
            //Converting DTO into Book entity
            var newBook = _mapper.Map<Book>(bookDto);

            var createdBook = await _bookRepository.Create(newBook, bookDto.GenreIds);

            var data = _mapper.Map<BookResponseDto>(createdBook);

            return GenericResult<BookResponseDto>.SuccessResult(data);
        }

        public Task<bool> Delete(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<BookResponseDto> Update(int bookId, UpdateBookDto bookDto)
        {
            var currentBook = await _bookRepository.GetOne(bookId);

            if (currentBook == null)
            {
                throw new BadRequestException($"No book found with id {bookId}")
                {
                    ErrorCode = "005"
                };

            }

            currentBook.Description = bookDto.Description;
            currentBook.CoverUrl = bookDto.CoverUrl;


            var updatedBook = await _bookRepository.Update(currentBook);

            return _mapper.Map<BookResponseDto>(updatedBook);
        }

        public async Task<IEnumerable<BookResponseDto>> Search(string? title, string? author)
        {

            var books = await _bookRepository.Search(title, author);


            return _mapper.Map<IEnumerable<BookResponseDto>>(books);
        }


    }
}
