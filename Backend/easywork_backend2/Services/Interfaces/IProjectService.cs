using easywork_backend.Dtos;
using easywork_backend2.Dtos.Project;

namespace easywork_backend2.Services;

public interface IProjectService
{
    Task<ResponseDto<ProjectDto>> CreateProjectAsync(CreateProjectDto dto);
    Task<ResponseDto<List<ProjectDto>>> GetProjectsAsync();
}