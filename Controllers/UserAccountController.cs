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
    public class UserAccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserAccountController(ApplicationDbContext context)
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
            var UserAccount =_context.UserAccounts.FirstOrDefault(UserAccount => UserAccount.Id == id);    
            if (UserAccount==null)
            {
                return NotFound();
            }
            return View(UserAccount);
        }
    
    


 [HttpGet("Creat")]
 public IActionResult Creat()
 {
    return View();
 }
 [HttpPost("Creat")]
 [ValidateAntiForgeryToken]

 public IActionResult Creat(UserAccount UserAccount)
 {
    _context.UserAccounts.Add(UserAccount);
    _context.SaveChanges();
    return RedirectToAction(nameof (Index));
 }
    }}