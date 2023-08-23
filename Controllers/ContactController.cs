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
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.contacts.ToList());
        }

       

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var Contact =_context.contacts.FirstOrDefault(Contact => Contact.ContactId == id);    
            if (Contact==null)
            {
                return NotFound();
            }
            return View(Contact);
        }
    
    


 [HttpGet("Creat")]
 public IActionResult Creat()
 {
    return View();
 }
 [HttpPost("Creat")]
 [ValidateAntiForgeryToken]

 public IActionResult Creat( Contact contact)
 {
    _context.contacts.Add(contact);
    _context.SaveChanges();
    return RedirectToAction(nameof (Index));
 }
    }
}