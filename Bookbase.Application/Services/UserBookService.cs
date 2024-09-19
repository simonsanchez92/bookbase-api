using AutoMapper;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Exceptions;
using Bookbase.Application.Interfaces;
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
    }
}
