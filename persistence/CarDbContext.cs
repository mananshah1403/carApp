using carApp.Models;
using Microsoft.EntityFrameworkCore;

namespace carApp.persistence
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options)
        :base(options)
        {
            
        }
         public DbSet<Make> Makes { get; set; }
    }
}