using AutoMapper;
using Bookbase.Application.Dtos.Requests;
using Bookbase.Application.Dtos.Responses;
using Bookbase.Application.Interfaces;
using Bookbase.Domain.Interfaces;

namespace Bookbase.Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task<CommentResponseDto> Create(CreateCommentDto commentDto)
        {
            throw new NotImplementedException();
        }

        public async Task<CommentResponseDto?> GetOne(int commentId)
        {
            var comment = await _commentRepository.GetOne(commentId);


            return _mapper.Map<CommentResponseDto>(comment);
        }
    }
}
