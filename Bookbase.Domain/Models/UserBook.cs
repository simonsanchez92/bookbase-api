using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("user_book")]
    public class UserBook : TimestampedModel
    {
        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Column("reading_status")]
        public int ReadingStatusId { get; set; }  //StatusId //Todo: crear tabla
        public ReadingStatus ReadingStatus { get; set; }

        [Column("rating")]
        public float Rating { get; set; } = 0.0f;

    }
}
