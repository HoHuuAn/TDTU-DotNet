using System.ComponentModel.DataAnnotations;

namespace Exercise.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Color { get; set; }
        public byte[]? Illustration { get; set; }
    }
}