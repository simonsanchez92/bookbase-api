using Bookbase.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    public class SoftDeletableModel : TimestampedModel, ISoftDeletable
    {
        [Column("deleted")]
        public bool Deleted { get; set; }
    }
}
