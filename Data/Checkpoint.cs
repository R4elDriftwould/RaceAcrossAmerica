using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RaceAcrossAmerica.Data
{
    public class Checkpoint
    {
        [Key]
        public int CheckpointId { get; set; }

        [Required]
        public string City { get; set; }
        public string State { get; set; }

        public int CumulativeMiles { get; set; }

        // --- This part links it back to the Race ---

        // The Foreign Key property
        public int RaceId { get; set; }

        // The navigation property
        [ForeignKey("RaceId")]
        public virtual Race Race { get; set; }
    }
}
