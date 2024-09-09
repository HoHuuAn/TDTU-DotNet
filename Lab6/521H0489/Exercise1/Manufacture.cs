using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Manufacture
    {
        [Key] public String ID { set; get; }

        [Required]
        [StringLength(128, MinimumLength = 3)]
        public String Name { set; get; }
        public String Location { set; get; }
        public int Employee { set; get; }
        public ICollection<Phone> Phones { set; get; }

        public override string ToString()
        {
            return ID + " " + Name + " " + Location + " " + Employee;
        }
    }
}
