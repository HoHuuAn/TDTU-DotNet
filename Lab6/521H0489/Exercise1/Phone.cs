using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Phone
    {
        [Key] public String ID { set; get; }

        [Required]
        [StringLength(128, MinimumLength = 3)] 
        public String Name { set; get; }
        [Required] public int Price { set; get; }
        [Required]  public String Color { set; get; }
        public String Country { set; get; }
        public int Quantity { set; get; }

        [ForeignKey("ManufactureId")]
        public Manufacture Manufacture { set; get; }
        public override string ToString()
        {
            return ID + " " + Name + " " + Price + " " +  Color + " " + Country + " " + Quantity + " " + Manufacture;
        }
    }
}
