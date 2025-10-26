using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceAcrossAmerica.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int LapsRun { get; set; }

        // --- ADD THESE LINES ---
        public int? GroupId { get; set; } // Nullable (int?) so a student doesn't *have* to be in a group

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
        // --- END OF ADDED LINES ---
    }
}
