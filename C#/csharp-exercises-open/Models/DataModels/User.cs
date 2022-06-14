using System.ComponentModel.DataAnnotations;

namespace csharp_exercises_open.Models.DataModels
{
    public class User 
    {
        [Required]
        [Key]
        public int Id { get; set; }
            
        [Required,StringLength(50)]
        public string Name {get; set;} = string.Empty;

        [Required,StringLength(100)]
        public string LastName {get; set;} = string.Empty;

        [Required,EmailAddress]
        public string Email {get; set;} = string.Empty;

        [Required]
        public string Password {get; set;} = string.Empty;

        public int? CreateById { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int? UpdateById { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? DeletedById { get; set; }

        public DateTime? DeleteAt { get; set; }
        
        public bool IsDeleted { get; set; } = false;
        
        public ICollection<User>? UsersCreate {get; set;} = new List<User>();
        public ICollection<User>? UsersUpdate {get; set;} = new List<User>();
        public ICollection<User>? UsersDeleted {get; set;} = new List<User>();
    
    }
}