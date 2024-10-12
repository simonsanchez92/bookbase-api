using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("comments")]

    public class Comment : TimestampedModel
    {
        [Column("comment_id")]
        public int Id { get; set; }

        [Column("content")]
        public required string Content { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Column("review_id")]
        public int ReviewId { get; set; }
        public Review Review { get; set; }


    }
}
