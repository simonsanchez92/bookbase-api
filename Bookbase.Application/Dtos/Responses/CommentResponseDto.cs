namespace Bookbase.Application.Dtos.Responses
{
    public class CommentResponseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReviewId { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
