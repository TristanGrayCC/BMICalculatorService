using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMIApplication.Data.Models
{
    public class UserData
    {
        [Key]
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
    }
}
