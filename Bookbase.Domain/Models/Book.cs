using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("books")]
    public class Book
    {
        [Column("book_id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }
        [Column("author")]
        public string Author { get; set; }

        [Column("publish_date")]
        public int PublishDate { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("cover_url")]
        public string CoverUrl { get; set; }

        [Column("pages")]
        public int PageCount { get; set; }

        [Column("deleted")]
        public bool Deleted { get; set; } = false;

        // Navigation properties
        public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>(); // Many-to-Many 
        public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>(); // Many-to-Many 
        //public ICollection<Review> Reviews { get; set; } // One-to-Many 


    }
}
