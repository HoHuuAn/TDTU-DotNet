using Exercise.DTO;
using Exercise.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Exercise.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(new
            {
                Message = "List of Products",
                Data = products,
            });
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Manager,Employee")]
        [RequestSizeLimit(10_000_000)]
        public async Task<ActionResult<Product>> PostProduct([FromBody] ProductDto productDto)
        {

            if (productDto.Illustration == null || productDto.Illustration.Length == 0)
            {
                return BadRequest("Illustration file is missing.");
            }

            if (productDto.Illustration.Length > 10_000_000)
            {
                return BadRequest("Illustration file size exceeds the limit of 10MB.");
            }

            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Color = productDto.Color,
                Illustration = productDto.Illustration
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = product.Id }, product);
        }
        

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(new
            {
                Message = "Details of product: " + id,
                Data = product,
            });
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> UpdatePut(int id, [FromBody] ProductDto productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = productDto.Name;
            product.Price = productDto.Price;
            product.Color = productDto.Color;
            product.Illustration = productDto.Illustration;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Update product with id: " + id,
                Data = product,
            });
        }

        [HttpPatch("{id}")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> UpdatePatch(int id, [FromBody] ProductDto productDto)
        {
            if (id != productDto.Id)
            {
                return BadRequest();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            if (productDto.Name != null)
            {
                product.Name = productDto.Name;
            }

            if (productDto.Price != 0)
            {
                product.Price = productDto.Price;
            }

            if (productDto.Color != null)
            {
                product.Color = productDto.Color;
            }

            if (productDto.Illustration != null)
            {
                product.Illustration = productDto.Illustration;
            }

            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Update patch product with id: " + id,
                Data = product,
            });
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                Message = "Delete product with id: " + id,
                Data = product,
            });
        }
    }
}
