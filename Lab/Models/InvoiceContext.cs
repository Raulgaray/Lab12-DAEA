using Microsoft.EntityFrameworkCore;
using LAB.Models;

namespace LAB.Models
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {

        }
    
        public DbSet<Product> Products { get; set; }           
        public DbSet<Product> Detail { get; set; }

        public DbSet<Product> Customer { get; set; }

        public DbSet<Product> Invoice { get; set; }

        public DbSet<LAB.Models.Customer>? Customer_1 { get; set; }

    }
}

