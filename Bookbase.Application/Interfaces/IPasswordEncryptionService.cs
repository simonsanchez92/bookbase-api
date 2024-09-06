﻿namespace Bookbase.Application.Interfaces
{
    public interface IPasswordEncryptionService
    {
        string HashPassword(string password);
        bool VerifyPassword(string hashedPassword, string providedPassword);

    }
}
