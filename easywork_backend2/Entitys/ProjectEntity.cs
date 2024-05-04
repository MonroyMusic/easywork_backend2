using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend2.Entitys;

public class ProjectEntity
{
    [Key] public Guid Id { get; set; }
    [Required] [StringLength(200)] public string Name { get; set; }
    [Required] [StringLength(500)] public string Description { get; set; }
    [Required] public DateTime Start_Time { get; set; }
    [Required] public DateTime End_Time { get; set; }
    [Required] [StringLength(150)] public string Project_Type { get; set; }
    public string User_Id { get; set; }
    public ProjectStateEnum State { get; set; }

    [ForeignKey(nameof(User_Id))] public virtual UserEntity User { get; set; }
}