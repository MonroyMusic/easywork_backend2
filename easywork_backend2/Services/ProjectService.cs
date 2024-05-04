using AutoMapper;
using easywork_backend.Dtos;
using easywork_backend2.Database;
using easywork_backend2.Dtos.Project;
using easywork_backend2.Entitys;
using easywork_backend2.Entitys.Log;
using easywork_backend2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend2.Services;

public class ProjectService : IProjectService
{
    private readonly EasyWorkDbContext _context;
    private readonly IMapper _mapper;
    private readonly LogDBContext _logDB;
    private readonly ILogServices _logServices;
    private readonly string _USER_ID = "";

    public ProjectService(ILogServices logServices, EasyWorkDbContext Context, IHttpContextAccessor httpContextAccesor, IMapper mapper,
        LogDBContext logDB)
    {
        _context = Context;
        _mapper = mapper;
        _logDB = logDB;
        _logServices = logServices;
        var idClaim = httpContextAccesor.HttpContext.User.Claims.Where(x => x.Type == "UserId").FirstOrDefault();
        _USER_ID = idClaim?.Value;
    }

    public async Task<ResponseDto<ProjectDto>> CreateProjectAsync(CreateProjectDto dto)
    {
        var project = _mapper.Map<ProjectEntity>(dto);

        project.Id = Guid.NewGuid();
        project.User_Id = _USER_ID;
        project.Start_Time = DateTime.Now;
        project.State = ProjectStateEnum.Pending;
        

        await _context.Projects.AddAsync(project);
        await _context.SaveChangesAsync();

        await _logServices.CreateLogAsync("Se creo el proyecto" + dto.Name);

        return new ResponseDto<ProjectDto>
        {
            Data = new ProjectDto
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                Start_Time = project.Start_Time,
                State = project.State,
                Project_Type = project.Project_Type,
                End_Time = project.End_Time,
                User_Id =  project.User_Id
            },
            StatusCode = 201
        };
    }

    public async Task<ResponseDto<List<ProjectDto>>> GetProjectsAsync()
    {
        var projects = await _context.Projects
            .Where(x => x.User_Id == _USER_ID)
            .ToListAsync();

        var projectDtos = _mapper.Map<List<ProjectDto>>(projects);

        return new ResponseDto<List<ProjectDto>>
        {
            Data = projectDtos,
            StatusCode = 200
        };
    }
}