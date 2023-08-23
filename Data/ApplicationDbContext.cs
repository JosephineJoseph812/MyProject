using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProject.Models;

namespace MyProject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get;set;}
        public DbSet<Contact> contacts { get;set;}
        public DbSet<Inventory> inventories { get;set;}
        public DbSet<Order> orders { get;set;}
        public DbSet<Product> products { get;set;}
        public DbSet<UserAccount> UserAccounts { get;set;}
    }
}