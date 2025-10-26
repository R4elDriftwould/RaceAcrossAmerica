using System.ComponentModel.DataAnnotations;

namespace RaceAcrossAmerica.Data
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property for all students in this group
        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}