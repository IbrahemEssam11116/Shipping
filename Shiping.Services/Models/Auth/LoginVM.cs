﻿namespace Shiping.Services.Models.Auth
{
    public class LoginVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? FCMToken { get; set; }
    }
}
