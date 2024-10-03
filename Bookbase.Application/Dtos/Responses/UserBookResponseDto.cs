﻿namespace Bookbase.Application.Dtos.Responses
{
    public class UserBookResponseDto
    {
        //public UserResponseDto User { get; set; }
        public required string Status { get; set; }
        public float Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
