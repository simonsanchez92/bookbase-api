using System.ComponentModel.DataAnnotations.Schema;

namespace Bookbase.Domain.Models
{
    [Table("users")]
    public class User
    {
        [Column("user_id")]
        public int Id { get; private set; }

        [Column("username")]
        public string Username { get; private set; }

        [Column("email")]
        public string Email { get; private set; }

        [Column("password")]
        public string PasswordHash { get; private set; }

        [Column("role_id")]
        public int RoleId { get; set; }
        public Role role { get; set; }



        public User() { }

        public User(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public User(int id, string username, string email, string passwordHash)
        {
            Id = id;
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }

        public void SetPasswordHash(string hashedPassword)
        {
            PasswordHash = hashedPassword;
        }
    }
}
