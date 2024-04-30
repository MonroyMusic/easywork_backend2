using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend.Entitys
{

    
    public class ProjectEntity

    {
        
        [Key]
        public Guid Id { get; set; }

        
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        
        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        
        [Required]
        public DateTime Start_Time { get; set; }

        
        [Required]
        public DateTime End_Time { get; set; }

        
        [Required]
        [StringLength(150)]
        public string Project_Type { get; set; }

        
        public Guid Task_Id { get; set; }

        
        public int State_Id { get; set; }

        [ForeignKey(nameof(Task_Id))]
        public virtual TaskEntity Task { get; set; }

        [ForeignKey(nameof(State_Id))]
        public virtual StatesEntity States { get; set; }

    }

}
