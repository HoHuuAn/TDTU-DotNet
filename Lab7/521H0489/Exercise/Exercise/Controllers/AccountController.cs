using Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace Exercise.Controllers
{
    public class AccountController : Controller
    {
        private readonly DatabaseContext dbContext;

        public AccountController(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account acc)
        {
            if(ModelState.IsValid)
            {
                dbContext.Accounts.Add(acc);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Index()
        {
            return View(dbContext.Accounts);
        }

        public IActionResult Details(string? id)
        {
            if (id == null)     return RedirectToAction("Index");
            Account acc = dbContext.Accounts.Where(x => x.id == id).FirstOrDefault();
            if (acc == null)    return RedirectToAction("Index");
            return View(acc);
        }

        public IActionResult Edit(string? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            Account acc = dbContext.Accounts.FirstOrDefault(x => x.id == id);
            if (acc == null)
                return RedirectToAction("Index");

            return View(acc);
        }

        [HttpPost]
        public IActionResult Edit(Account updatedAccount)
        {
            if (ModelState.IsValid)
            {
                Account acc = dbContext.Accounts.FirstOrDefault(x => x.id == updatedAccount.id);
                if (acc == null)
                    return RedirectToAction("Index");

                acc.fullname = updatedAccount.fullname;
                acc.email = updatedAccount.email;
                acc.password = updatedAccount.password;
                acc.roles = updatedAccount.roles;
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(updatedAccount);
        }

        public IActionResult Delete(string? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            Account acc = dbContext.Accounts.FirstOrDefault(x => x.id == id);
            if (acc == null)
                return RedirectToAction("Index");

            return View(acc);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(string id)
        {
            Account acc = dbContext.Accounts.FirstOrDefault(x => x.id == id);
            if (acc != null)
            {
                dbContext.Accounts.Remove(acc);
                dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
