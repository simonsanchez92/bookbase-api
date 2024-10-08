﻿namespace Bookbase.Application.Dtos.Responses
{
    public class ReviewResponseDto
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Content { get; set; }
        public int CommentsCount { get; set; }
        public int LikesCount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
