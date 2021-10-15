using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Shared.DTOs.Users
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
