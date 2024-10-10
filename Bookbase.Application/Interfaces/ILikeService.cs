using Bookbase.Application.Dtos.Responses;

namespace Bookbase.Application.Interfaces
{
    public interface ILikeService
    {
        public Task<LikeResponseDto> Create(int reviewId, int userId);
        public Task<LikeResponseDto?> GetOne(int reviewId, int userId);
        public Task<bool> Delete(int reviewId, int userId);
        //public Task<GenericListResponse<LikeResponseDto>> GetList(int reviewId, int page, int pageSize);
    }
}
