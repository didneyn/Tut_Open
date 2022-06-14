using System.ComponentModel.DataAnnotations;

namespace csharp_exercises_open.Models.DataModels
{
    public class BaseEntity 
    {
        [Required]
        [Key]
        public int Id { get; set; }
        
        public int? CreateById { get; set; }
        
        public virtual User? CreateBy { get; set; } 

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int? UpdateById { get; set; }

        public virtual User? UpdateBy { get; set; } 

        public DateTime? UpdateAt { get; set; }

        public int? DeletedById { get; set; }

        public virtual User? DeletedBy { get; set; } 

        public DateTime? DeleteAt { get; set; }
        
        public bool IsDeleted { get; set; } = false;
    }
}
