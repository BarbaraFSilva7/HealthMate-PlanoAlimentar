using Microsoft.EntityFrameworkCore;

namespace HealthMate_PlanoAlimentar.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Dieta> PlanoAlimentar { get; set; }
    }
}
