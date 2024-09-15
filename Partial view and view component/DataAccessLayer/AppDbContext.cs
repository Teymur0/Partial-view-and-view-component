using Microsoft.EntityFrameworkCore;
using Partial_view_and_view_component.DataAccessLayer.Entites;

namespace Partial_view_and_view_component.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
