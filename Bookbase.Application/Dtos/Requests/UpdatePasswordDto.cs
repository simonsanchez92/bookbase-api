﻿namespace Bookbase.Application.Dtos.Requests
{
    public class UpdatePasswordDto
    {
        public required string CurrentPassword { get; set; }
        public required string NewPassword { get; set; }
        public required string ConfirmNewPassword { get; set; }
    }
}
