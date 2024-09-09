using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class Account
    {
        [Key]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<string>? Roles { get; set; }
    }
}