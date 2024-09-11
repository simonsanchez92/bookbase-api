﻿using Bookbase.Domain.Interfaces;

namespace Bookbase.Infrastructure.Services
{
    public class PasswordEncryptionService : IPasswordEncryptionService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string hashedPassword, string providedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
        }
    }
}
