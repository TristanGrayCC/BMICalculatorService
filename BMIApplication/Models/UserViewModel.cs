using BMIApplication.Services;
using System;

namespace BMIApplication.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public decimal BMI
        {
            get => BMIGeneratorService.CalculateBMI(Height, Weight);
        }
    }
}