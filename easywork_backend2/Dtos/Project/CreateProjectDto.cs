namespace easywork_backend2.Dtos.Project;

public class CreateProjectDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime End_Time { get; set; }
    public string Project_Type { get; set; }
}