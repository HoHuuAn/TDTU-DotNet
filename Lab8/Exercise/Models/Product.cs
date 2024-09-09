
using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    [Range(1, 10000, ErrorMessage = "The price must be between 1-10,0000")]
    public decimal Price { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }

    public int Storage { get; set; }
    public int Quantity { get; set; }
}