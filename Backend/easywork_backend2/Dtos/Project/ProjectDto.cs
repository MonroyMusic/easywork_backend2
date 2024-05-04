using easywork_backend2.Entitys;

namespace easywork_backend2.Dtos.Project;

public class ProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime Start_Time { get; set; }
    public DateTime End_Time { get; set; }
    public string Project_Type { get; set; }
    public string User_Id { get; set; }
    public ProjectStateEnum State { get; set; }
}