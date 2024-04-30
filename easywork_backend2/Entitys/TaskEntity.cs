using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend.Entitys
{

    public class TaskEntity
    {

        
        [Key]
        [Required]
        public Guid Id { get; set; }

        
        [Required]
        [StringLength(350)]
        public string Description { get; set; }

        
        [Required]
        public bool State { get; set; }

        
        [Required]
        public DateTime Start_Time { get; set; }

        
        [Required]
        public DateTime End_Time { get; set; }

        
        [Required]
        [StringLength(300)]
        public string Coment { get; set; }

        
        public int Priority_Id { get; set; }

        [ForeignKey(nameof(Priority_Id))]
        public virtual PriorityEntity Prioity{ get; set; }


    }

}
