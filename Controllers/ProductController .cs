using fruit.Data;
using fruit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace fruit.Controllers
{   
    [Route("[controller]")]
    public class ProductController : Controller
    {


        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var product = _context.Products.ToList();
            return View(product);
        }
        [HttpGet("Details/{id}")]
        public IActionResult Details(int? id)
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
            return View(product);

        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Inventories = _context.Inventories.ToList();
            return View();
        }

        [HttpPost("Create")]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Inventories = _context.Inventories.ToList();
            return View(product);
        }

[HttpGet("Edit/{id}")]
public IActionResult Edit(int? id)
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

[HttpPost("Edit/{id}")]
public IActionResult Edit(Product product)
{
    if (product == null)
    {
        return NotFound();
    }

    if (ModelState.IsValid)
    {
        _context.Update(product);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    ViewBag.Categories = _context.Categories.ToList();
    ViewBag.Inventories = _context.Inventories.ToList();
    return View(product);
}

    [HttpGet("Delete/{id}")]
    public IActionResult Delete(int? id)
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
        return View(product);
    }

    [HttpPost("Delete/{id}")]
    public IActionResult DeleteConfirmed(int id)
        {   
            var product = _context.Products.FirstOrDefault(c => c.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




    }
}