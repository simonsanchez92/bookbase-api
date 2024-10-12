using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    public class TimestampedModel : BaseModel
    {
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
