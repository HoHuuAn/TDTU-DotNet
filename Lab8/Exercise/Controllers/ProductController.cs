using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProductController: Controller {
    private readonly ApplicationDbContext ct;

    public ProductController(ApplicationDbContext ct) {
        this.ct = ct;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index() {
        return View(await ct.Products.ToListAsync());
    }

    [Authorize]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
        if (ModelState.IsValid)
        {
            ct.Products.Add(product);
            await ct.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(product);
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete(int? id)
    {
        if (!id.HasValue) return RedirectToAction("Index");

        var product = await ct.Products.FindAsync(id);
        if (product == null)
        {
            return RedirectToAction("Index");
        }
        return View(product);
    }

    [Authorize]
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var product = await ct.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        ct.Products.Remove(product);
        await ct.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return RedirectToAction("Index");
        var product = await ct.Products.FirstOrDefaultAsync(m => m.Id == id);
        if (product == null) return RedirectToAction("Index");
        return View(product);
    }

    [Authorize]
    [Authorize(Roles = "Admin,Manager")]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return RedirectToAction("Index");
        var product = await ct.Products.FindAsync(id);
        if (product == null) return RedirectToAction("Index");
        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin,Manager")]
    public async Task<IActionResult> Edit(int id, Product product)
    {
        if (id != product.Id) return RedirectToAction("Index");

        if (ModelState.IsValid)
        {
            try
            {
                ct.Update(product);
                await ct.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index");
        }
        return View(product);
    }

    private bool ProductExists(int id)
    {
        return ct.Products.Any(e => e.Id == id);
    }



}