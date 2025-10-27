using System.ComponentModel.DataAnnotations;
namespace RaceAcrossAmerica.Data
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }

        [Required]
        public string Name { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public virtual ICollection<Checkpoint> Checkpoints { get; set; }

        // --- NEW ---
        // Navigation property for RaceParticipants (Many-to-Many join entity)
        public virtual ICollection<RaceParticipant> RaceParticipants { get; set; }
        // -------------

        public Race()
        {
            // This ensures the collection is an empty list, not null.
            Checkpoints = new List<Checkpoint>();
        }
    }
}
