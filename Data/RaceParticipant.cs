// Data/RaceParticipant.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceAcrossAmerica.Data
{
    // This class represents the joining entity for the many-to-many relationship
    // between Race and Student.
    public class RaceParticipant
    {
        [Key]
        public int RaceParticipantId { get; set; } // Primary key for the join table itself

        // Foreign key for Race
        public int RaceId { get; set; }
        [ForeignKey("RaceId")]
        public virtual Race Race { get; set; }

        // Foreign key for Student
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        // Optional: You could add race-specific data here later,
        // like a student's assigned number for THIS race,
        // or potentially override laps JUST for this race if needed.
        // For now, we'll keep it simple.
        // public int LapsOverride { get; set; } // Example for later
    }
}