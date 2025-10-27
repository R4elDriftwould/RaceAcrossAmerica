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
        public DbSet<Group> Groups { get; set; }

        // --- NEW ---
        // Add DbSet for the joining entity
        public DbSet<RaceParticipant> RaceParticipants { get; set; }
        // -------------

        // Optional: Fluent API configuration for complex relationships (often needed for Many-to-Many)
        // Although EF Core can often infer simple join tables, explicitly defining keys can be safer.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Call base method if you have other configurations

            // --- NEW ---
            // Configure the composite key for the join table
            // This might not be strictly necessary if EF Core infers it correctly, but it's good practice.
            // modelBuilder.Entity<RaceParticipant>()
            //     .HasKey(rp => new { rp.RaceId, rp.StudentId }); // Define composite primary key (alternative to single RaceParticipantId)

            // Configure the relationships explicitly
            modelBuilder.Entity<RaceParticipant>()
                .HasOne(rp => rp.Race)
                .WithMany(r => r.RaceParticipants) // Use the navigation property name from Race.cs
                .HasForeignKey(rp => rp.RaceId)
                .OnDelete(DeleteBehavior.Cascade); // Or Restrict, depending on desired behavior

            modelBuilder.Entity<RaceParticipant>()
                .HasOne(rp => rp.Student)
                .WithMany(s => s.RaceParticipations) // Use the navigation property name from Student.cs
                .HasForeignKey(rp => rp.StudentId)
                .OnDelete(DeleteBehavior.Cascade); // Or Restrict
            // -------------
        }
    }
}
