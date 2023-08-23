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
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.orders.ToList());
        }

        

        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            var Order =_context.orders.FirstOrDefault(Order => Order.OrdersId == id);    
            if (Order==null)
            {
                return NotFound();
            }
            return View(Order);
        }
    
    


 [HttpGet("Creat")]
 public IActionResult Creat()
 {
    return View();
 }
 [HttpPost("Creat")]
 [ValidateAntiForgeryToken]

 public IActionResult Creat(Order Order)
 {
    _context.orders.Add(Order);
    _context.SaveChanges();
    return RedirectToAction(nameof (Index));
 }
}
}