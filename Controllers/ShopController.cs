using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using fruit.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fruit.Controllers
{
    [Route("[controller]")]
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var product = _context.Products.ToList();
            return View(product);
        }

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }

    }
}