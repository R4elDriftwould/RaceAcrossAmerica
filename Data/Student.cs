using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceAcrossAmerica.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        public int LapsRun { get; set; } // The *total* laps run by the student

        // Foreign key for Group (One-to-Many, optional)
        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        // --- NEW ---
        // Navigation property for RaceParticipants (Many-to-Many join entity)
        public virtual ICollection<RaceParticipant> RaceParticipations { get; set; }
        // -------------

        // --- NEW ---
        public Student() // Add constructor if one doesn't exist
        {
            RaceParticipations = new List<RaceParticipant>(); // Initialize the collection
        }
        // -------------
    }
}
