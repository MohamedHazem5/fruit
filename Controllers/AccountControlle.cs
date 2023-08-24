using fruit.Data;
using fruit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace fruit.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {


        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Account account)
        {
           
            if (ModelState.IsValid)
            {
               
               _context.Accounts.Add(account);
               _context.SaveChanges();

            }
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

      [HttpPost("Login")]
        public IActionResult Login (Account account)
        {

            var Account = _context.Accounts.FirstOrDefault(c => c.email== account.email && c.password == account.password);
            if (Account == null)
            {
                return View(account);
            }


            return RedirectToAction("Index", "Home");

        }


    }
}