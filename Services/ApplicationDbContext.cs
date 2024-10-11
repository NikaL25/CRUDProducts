using CRUDProducts.Modules;
using Microsoft.EntityFrameworkCore;

namespace CRUDProducts.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }    
    }
}
