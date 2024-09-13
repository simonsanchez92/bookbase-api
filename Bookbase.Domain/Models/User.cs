using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("users")]
    public class User
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

        [Column("deleted")]
        public bool Deleted { get; set; } = false;

        //Navigation property
        public ICollection<UserBook> UserBooks { get; set; } //Many to many with book

    }
}
    