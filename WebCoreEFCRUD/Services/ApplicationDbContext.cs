using Microsoft.EntityFrameworkCore;
using WebCoreEFCRUD.Models;

namespace WebCoreEFCRUD.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
