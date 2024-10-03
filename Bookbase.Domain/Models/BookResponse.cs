namespace Bookbase.Domain.Models
{
    public class BookResponse
    {
        public Book Book { get; set; }
        public UserBook? UserBook { get; set; }
    }
}
