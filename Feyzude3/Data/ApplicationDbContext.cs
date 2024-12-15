using Feyzude3.Models;
using Microsoft.EntityFrameworkCore;

namespace Feyzude3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employees> Emplooyees { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }

    }
}
