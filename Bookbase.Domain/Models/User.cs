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



        //public User() { }

        //public User(string username, string email)
        //{
        //    Username = username;
        //    Email = email;
        //}

        //public User(int id, string username, string email, string passwordHash)
        //{
        //    Id = id;
        //    Username = username;
        //    Email = email;
        //    Password = passwordHash;
        //}

        public void SetPasswordHash(string hashedPassword)
        {
            Password = hashedPassword;
        }
    }
}
