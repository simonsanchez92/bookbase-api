using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("reviews")]
    public class Review
    {
        [Column("review_id")]
        public int Id { get; set; }

        [Column("content")]
        public string content { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }


        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; } //Nav property

        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; } //Nav property


        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Like> Likes { get; set; } = new List<Like>();

    }
}
