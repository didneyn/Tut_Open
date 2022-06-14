using System.ComponentModel.DataAnnotations;

namespace csharp_exercises_open.Models.DataModels
{
    public class Student: BaseEntity 
    {
        [Required,StringLength(50)]
        public string Name {get; set;} = string.Empty;

        [Required,StringLength(100)]
        public string LastName {get; set;} = string.Empty;

        [Required]
        public DateTime Dob {get; set;}

        [Required]
        public ICollection<Course> Courses {get; set;} = new List<Course>();
    }
}