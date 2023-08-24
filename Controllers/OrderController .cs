using fruit.Data;
using fruit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fruit.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
             ViewBag.Categories = _context.Categories.ToList();
             ViewBag.Inventories = _context.Inventories.ToList();
            return View(product);

        }
        
[HttpPost("Create")]
public IActionResult Create(Order order)
{
    if (ModelState.IsValid)
    {

        var userName = User.Identity.Name;


        var user = _context.Accounts.FirstOrDefault(u => u.Name == userName);

        if (user != null)
        {
            order.Account = user;
            _context.Orders.Add(order);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        else
        {
            return RedirectToAction("Error", "Home");
        }
    }
    return View(order);
}






    }
}