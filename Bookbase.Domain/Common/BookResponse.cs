namespace Bookbase.Domain.Common
{
    public class BookResponse
    {
        public int BookId { get; set; }
        public string CoverUrl { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        //public float AvgRating { get; set; }
        //public float Rating { get; set; }
        public string Status { get; set; }

        //public string Review { get; set; }

        //public DateTime DateRead { get; set; }
        //public DateTime DateAdded { get; set; }
    }
}
