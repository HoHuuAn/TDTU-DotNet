using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string RoleName { get; set; }

        public virtual Account User { get; set; }
    }

}
