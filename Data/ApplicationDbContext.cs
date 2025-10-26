using Microsoft.EntityFrameworkCore;

namespace RaceAcrossAmerica.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Tell EF Core to create a Students table based on the Students class
        public DbSet<Student> Students { get; set; }

        public DbSet<Race> Races { get; set; }
        public DbSet<Checkpoint> Checkpoints { get; set; }
    }
}
