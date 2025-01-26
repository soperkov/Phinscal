﻿using System.ComponentModel.DataAnnotations;

namespace Phinscal.Models
{
    public class UserModel
    {
        [Key] public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
