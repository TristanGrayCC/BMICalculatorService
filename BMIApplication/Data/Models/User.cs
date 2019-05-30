using System;
using System.ComponentModel.DataAnnotations;

namespace BMIApplication.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual UserData Data { get; set; }
    }
}
