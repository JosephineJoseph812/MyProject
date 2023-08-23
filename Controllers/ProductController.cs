using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.Data;
using MyProject.Models;


namespace MyProject.Controllers
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
            return View(_context.products.ToList());
        }

        

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var Product =_context.products.FirstOrDefault(Product => Product.ProductId == id);    
            if (Product==null)
            {
                return NotFound();
            }
            return View(Product);
        }
    
    

 [HttpGet("Creat")]
 public IActionResult Creat()
 {
    return View();
 }
 [HttpPost("Creat")]
 [ValidateAntiForgeryToken]

 public IActionResult Creat(Product Product)
 {
    _context.products.Add(Product);
    _context.SaveChanges();
    return RedirectToAction(nameof (Index));
 }
 [HttpGet("Edit/{id}")]

 public IActionResult Edit(int? id)
 {
    if (id==0)
    {
        return NotFound();
    }
    var product= _context.products.FirstOrDefault(Product => Product.ProductId == id);    
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
 

 [HttpPost]
 public IActionResult Edit(int id , Product Product)
 {
    
    if (ModelState.IsValid)
    {
        _context.Update(Product);
        _context.SaveChanges();
        return RedirectToAction (nameof(Index));
    }
    return View(Product);
 }

 [HttpGet("Delet/{id}")]
 public IActionResult Delete (int? id){
 if(id==0)
 {
    return NotFound();
 }
 var Product =_context.products.FirstOrDefault(Product => Product.ProductId == id);    
            if (Product==null)
            {
                return NotFound();
            }
            return View(Product);
        
    
 }
     [HttpPost("Delete")]
     public IActionResult Deletconfirmed(int id)
{
    var Product=_context.products.FirstOrDefault(Product => Product.ProductId == id);    
              _context.products.Remove(Product);
              _context.SaveChanges();
              return RedirectToAction(nameof(Index));
        }
      }
}