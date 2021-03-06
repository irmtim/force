using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Force.Tests.Infrastructure.Context
{
    public class TestsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public TestsDbContext(DbContextOptions options) : base(options)
        {            
        }
    }
}