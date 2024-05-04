using easywork_backend2.Dtos.Project;
using easywork_backend2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace easywork_backend2.Controllers;

[Route("api/projects")]
[ApiController]
[Authorize(AuthenticationSchemes = "Bearer ")]
public class ProjectsController : ControllerBase
{
    private readonly IProjectService _projectService;

    public ProjectsController(IProjectService projectService)
    {
        _projectService = projectService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateProjectAsync([FromBody] CreateProjectDto dto)
    {
        var response = await _projectService.CreateProjectAsync(dto);
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet]
    public async Task<IActionResult> GetProjectsAsync()
    {
        var response = await _projectService.GetProjectsAsync();
        return StatusCode(response.StatusCode, response);
    }
}