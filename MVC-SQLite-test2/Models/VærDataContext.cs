using Microsoft.EntityFrameworkCore;

namespace MVC_SQLite_test2.Models
{
    public class VærDataContext : DbContext
    {
        public VærDataContext(DbContextOptions<VærDataContext> options)
            : base(options)
        {
        }

        public DbSet<VærData> VærData { get; set; } = default!;
    }
}
