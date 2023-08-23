using Microsoft.AspNetCore.Mvc;
using MyProject.Data;
using MyProject.Models;
using System.Linq;

namespace MyProject.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.categories.ToList());
        }

        

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var category =_context.categories.FirstOrDefault(category => category.CategoriesId == id);    
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
    
    


 [HttpGet("Create")]
 public IActionResult Create()
 {
    return View();
 }
 [HttpPost("Create")]
 [ValidateAntiForgeryToken]

 public IActionResult Create(Category category)
 {
    _context.categories.Add(category);
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
    var category= _context.categories.FirstOrDefault(category => category.CategoriesId == id);    
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
 public IActionResult Edit(int id , Category category)
 {
    
    if (ModelState.IsValid)
    {
        _context.Update(category);
        _context.SaveChanges();
        return RedirectToAction (nameof(Index));
    }
    return View(category);
 }

[HttpGet("Delete/{id}")]
 public IActionResult Delete (int? id){
 if(id==0)
 {
    return NotFound();
 }
 var category =_context.categories.FirstOrDefault(category => category.CategoriesId == id);    
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
    
      
     [HttpPost, ActionName("Delete")]
     public IActionResult Deleteconfirmed(int id)
{
    var category=_context.categories.FirstOrDefault(category => category.CategoriesId == id);    
              _context.categories.Remove(category);
              _context.SaveChanges();
              return RedirectToAction(nameof(Index));
        }
 }

   }