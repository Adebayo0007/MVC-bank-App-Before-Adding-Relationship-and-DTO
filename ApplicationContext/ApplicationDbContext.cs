using Bank_App.Models;
using Microsoft.EntityFrameworkCore;
using MVC_MobileBankApp.Models;

namespace MVC_MobileBankApp.ApplicationContext
{
    public class ApplicationDbContext : DbContext
    {
     
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
        public DbSet<Admin> Admins   {get; set;}
        public DbSet<Manager> Managers  {get; set;}
        public DbSet<CEO> CEOs  {get; set;}   
         public DbSet<Customer> Customers  {get; set;}       
          public DbSet<Transaction> Transactions  {get; set;}  
    
    }
}