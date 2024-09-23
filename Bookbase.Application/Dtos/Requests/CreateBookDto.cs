namespace Bookbase.Application.Dtos.Requests
{
    public class CreateBookDto
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int? PublishDate { get; set; }
        public string? Description { get; set; }
        public string? CoverUrl { get; set; }
        public int? PageCount { get; set; }
        public List<int>? GenreIds { get; set; }
    }
}
