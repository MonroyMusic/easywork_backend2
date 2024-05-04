using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend.Entitys
{

    public class StatesEntity
    {

        
        [Key]
        public int Id { get; set; }

        
        [Required]
        [StringLength(50)]
        public string Description { get; set; }

    }
}
