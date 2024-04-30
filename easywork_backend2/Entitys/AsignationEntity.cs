using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend.Entitys;



    
    public class AsignationEntity
    {

        
        [Key]
        [Required]
        public Guid Id { get; set; }

        
        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        
        public bool State {  get; set; }

        
        public Guid Task_Id { get; set; }


        [ForeignKey(nameof(Task_Id))]
        public virtual TaskEntity Task { get; set; }

    }
}
