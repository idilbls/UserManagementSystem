using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Shared.DTOs.Users
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
