﻿namespace Bookbase.Application.Dtos.Requests
{
    public class CreateUserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

    }

}
