using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend2.Entitys.Log
{
    public class LogEntity
    {

        [Key][Required] public Guid Id { get; set; }

        [Required] public string Action { get; set; }

        [Required] public DateTime Time { get; set; }

        [Required] public string User_Id { get; set; }

    }
}
