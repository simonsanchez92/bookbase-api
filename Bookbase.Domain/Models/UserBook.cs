using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("user_book")]
    public class UserBook
    {
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("status")]
        public string Status { get; set; }  // E.g., "Want to Read", "Reading", "Read"
    }
}
