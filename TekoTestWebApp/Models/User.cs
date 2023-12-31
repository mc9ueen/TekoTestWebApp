﻿using System.ComponentModel.DataAnnotations;
using TekoTestWebApp.Data.Enum;

namespace TekoTestWebApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? FullName { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }
        public int Age { get; set; }
        public DateTime? RegistrationTime { get; set; }
        public Gender Gender { get; set; }
    }
}
