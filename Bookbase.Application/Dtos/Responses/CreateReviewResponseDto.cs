namespace Bookbase.Application.Dtos.Responses
{
    public class CreateReviewResponseDto
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required string Content { get; set; }
        //public int CommentsCount { get; set; }
        //public int LikesCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
