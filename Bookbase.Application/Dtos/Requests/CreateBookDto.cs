namespace Bookbase.Application.Dtos.Requests
{
    public class CreateBookDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string CoverUrl { get; set; }
        public int PageCount { get; set; }

        public List<int> GenreIds { get; set; }
    }
}
