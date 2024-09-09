using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? OrderCode { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public List<OrderProduct>? Products { get; set; }
    }
}
