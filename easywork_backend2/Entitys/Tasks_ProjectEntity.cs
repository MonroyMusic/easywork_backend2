using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using easywork_backend2.Entitys;

namespace easywork_backend.Entitys
{
    public class Tasks_ProjectEntity
    {
        [Key] public Guid Id { get; set; }
        public Guid Task_Id { get; set; }
        public Guid Project_Id { get; set; }
        [ForeignKey(nameof(Task_Id))] public virtual TaskEntity Task { get; set; }

        [ForeignKey(nameof(Project_Id))] public virtual ProjectEntity Project { get; set; }
    }
}