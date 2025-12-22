using front_to_back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace front_to_back.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Slide> Sliders { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
