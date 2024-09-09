using Exercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise.Controllers
{
    public class ProductController : Controller
    {
        private readonly DatabaseContext dbContext;

        public ProductController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(String id)
        {
            if (id == null) return RedirectToAction("Index");
            Product product = dbContext.Products.Where(x => x.id == id).FirstOrDefault();
            if (product == null) return RedirectToAction("Index");
            return View(product);
        }
    }
}
