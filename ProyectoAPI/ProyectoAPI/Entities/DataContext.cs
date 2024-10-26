using Microsoft.EntityFrameworkCore;

namespace ProjectName.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }
        public DbSet<Product> Products { get; set; }
    }
}
