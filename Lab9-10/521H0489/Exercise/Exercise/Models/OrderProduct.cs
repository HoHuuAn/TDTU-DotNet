using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class OrderProduct
    {
        [Key]
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}
