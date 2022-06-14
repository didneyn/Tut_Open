using System.ComponentModel.DataAnnotations;

namespace csharp_exercises_open.Models.DataModels
{

    public class PrincipalObjective: BaseEntity 
    {
        [Required,StringLength(50)]
        public string Name {get; set;} = string.Empty;

        [Required,StringLength(50)]
        public string Description {get; set;} = string.Empty;

        public ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}