namespace Bookbase.Application.Dtos.Requests
{
    public class CreateCommentDto
    {
        public required string Content { get; set; }
        public int ReviewId { get; set; }

    }
}
