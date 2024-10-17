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
    public class BookService : BaseService<Book, BookResponseDto, BookDetailedResponseDto, CreateBookDto, UpdateBookDto>, IBookService
    {
        private readonly IUserBookRepository _userBookRepository;
        private new readonly IBookRepository _repository;

        public BookService(IBookRepository repository, IUserBookRepository userBookRepository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _userBookRepository = userBookRepository;
        }


        public async Task<GenericListResponse<BookDetailedResponseDto>> GetList(int? userId, int page, int pageSize, string? query)
        {
            var books = await _repository.GetList(userId, page, pageSize, query);


            return _mapper.Map<GenericListResponse<BookDetailedResponseDto>>(books);
        }

        public async Task<BookDetailedResponseDto?> GetOne(int? userId, int bookId)
        {
            var book = await _repository.GetOne(userId, bookId);

            if (book == null)
            {
                throw new NotFoundException("Book not found")
                {
                    ErrorCode = "003"
                };
            }

            return _mapper.Map<BookDetailedResponseDto>(book);
        }

        public override async Task<BookResponseDto> Create(CreateBookDto bookDto)
        {
            //Converting DTO into Book entity
            var newBook = _mapper.Map<Book>(bookDto);
            var createdBook = await _repository.Create(newBook, bookDto.GenreIds);

            return _mapper.Map<BookResponseDto>(createdBook);
        }

        public async Task<IEnumerable<BookDetailedResponseDto>> GetAll(int? userId)
        {
            var results = await _repository.GetAllWithIncludes(userId);

            return _mapper.Map<IEnumerable<BookDetailedResponseDto>>(results);

        }

    }
}
