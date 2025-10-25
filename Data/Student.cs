using System.ComponentModel.DataAnnotations;

namespace RaceAcrossAmerica.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int LapsRun { get; set; }
    }
}
