using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("users")]
    public class User : SoftDeletableModel
    {
        [Column("user_id")]
        public int Id { get; set; }

        [Column("username")]
        public string Username { get; set; } = null;

        [Column("email")]
        public string Email { get; set; } = null;

        [Column("password")]
        public string Password { get; set; } = null;

        [Column("role_id")]
        public int RoleId { get; set; }
        public Role role { get; set; }

        //Navigation property
        public ICollection<UserBook> UserBooks { get; set; } //Many to many with book

    }
}
