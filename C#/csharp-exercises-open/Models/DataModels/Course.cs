using System.ComponentModel.DataAnnotations;
using csharp_exercises_open.Models;
using csharp_exercises_open.Models.Enums;

namespace csharp_exercises_open.Models.DataModels
{

    public class Course: BaseEntity 
    {
        [Required,StringLength(50)]
        public string Name {get; set;} = string.Empty;

        [Required,StringLength(280)]
        public string ShortDescription {get; set;} = string.Empty;

        [Required]
        public string LongDescription {get; set;} = string.Empty;

        [Required]
        public PrincipalObjective PublicObjective {get; set;} = new PrincipalObjective();

        [Required]
        public ICollection<Objective> Objectives {get; set;} = new List<Objective>();

        [Required]
        public string Requirements {get; set;} = string.Empty;
        
        [Required]
        public Level Level {get; set;} = Level.Basic;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Required]
        public ICollection<Student> Students {get; set;} = new List<Student>();

        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

    }
}