namespace Bookbase.Application.Dtos.Requests
{
    public class CreateReviewDto
    {
        public int UserId { get; set; }
        public required int BookId { get; set; }
        public required string Content { get; set; }
    }
}
