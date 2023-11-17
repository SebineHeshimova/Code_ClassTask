using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
