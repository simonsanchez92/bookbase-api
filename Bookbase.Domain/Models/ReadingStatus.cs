using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("reading_statuses")]
    public class ReadingStatus : BaseModel
    {
        [Column("reding_status_id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public ICollection<UserBook> UserBooks { get; set; }
    }
}
