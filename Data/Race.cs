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

        public Race()
        {
            // This ensures the collection is an empty list, not null.
            Checkpoints = new List<Checkpoint>();
        }
    }
}
