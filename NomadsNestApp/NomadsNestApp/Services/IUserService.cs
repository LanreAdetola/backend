﻿using NomadsNestApp.Models;

namespace NomadsNestApp.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        string GenerateJwtToken(User user);
    }
}
