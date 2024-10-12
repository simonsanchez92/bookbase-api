using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("books")]
    public class Book : SoftDeletableModel
    {
        [Column("book_id")]
        public int Id { get; set; }

        [Column("title")]
        [Required]
        public string Title { get; set; }

        [Column("author")]
        [Required]
        public string Author { get; set; }

        [Column("publish_year")]
        public int? PublishYear { get; set; }

        [Column("description")]
        [Required]
        public string? Description { get; set; }

        [Column("cover_url")]
        public string? CoverUrl { get; set; }

        [Column("pages")]
        public int? PageCount { get; set; }

        // Navigation properties
        public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>(); // Many-to-Many 
        public ICollection<UserBook> UserBooks { get; set; } = new List<UserBook>(); // Many-to-Many 
        public ICollection<Review> Reviews { get; set; } = new List<Review>(); // One-to-Many 
    }
}
