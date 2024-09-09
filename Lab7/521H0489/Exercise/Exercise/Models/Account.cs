using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise.Models
{
    public class Account
    {
        [Key]
        public string id { get; set; }

        [StringLength(128, MinimumLength = 3)]
        public string fullname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string roles {  get; set; }
    }
}
