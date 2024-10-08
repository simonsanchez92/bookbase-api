namespace Bookbase.Application.Dtos.Responses
{
    public class ReviewResponseDto
    {
        public int Id { get; set; }
        public required string Content { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        //public int UserId { get; set; } // Include User ID if needed
        //public int BookId { get; set; } // Include Book ID if needed
        //public ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();
        //public ICollection<LikeDto> Likes { get; set; } = new List<LikeDto>();
        public DateTime CreatedAt { get; set; }
    }
}
