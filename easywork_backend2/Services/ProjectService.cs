using AutoMapper;
using easywork_backend.Dtos;
using easywork_backend2.Database;
using easywork_backend2.Dtos.Project;
using easywork_backend2.Entitys;
using easywork_backend2.Entitys.Log;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend2.Services;

public class ProjectService : IProjectService
{
    private readonly EasyWorkDbContext _context;
    private readonly IMapper _mapper;
    private readonly LogDBContext _logDB;
    private readonly string _USER_ID = "";

    public ProjectService(EasyWorkDbContext Context, IHttpContextAccessor httpContextAccesor, IMapper mapper,
        LogDBContext logDB)
    {
        _context = Context;
        _mapper = mapper;
        _logDB = logDB;
        var idClaim = httpContextAccesor.HttpContext.User.Claims.Where(x => x.Type == "UserId").FirstOrDefault();
        _USER_ID = idClaim?.Value;
    }

    public async Task<ResponseDto<ProjectDto>> CreateProjectAsync(CreateProjectDto dto)
    {
        var project = _mapper.Map<ProjectEntity>(dto);

        //var log = _mapper.Map<LogsEntity>(dto);

        project.Id = Guid.NewGuid();
        project.User_Id = _USER_ID;
        project.Start_Time = DateTime.Now;
        project.State = ProjectStateEnum.Pending;

        //log.Id = Guid.NewGuid();
        //log.User_Id = _USER_ID;
        //log.Action = "Creo un proyecto";
        //log.Time = DateTime.Now;

        await _context.Projects.AddAsync(project);
        await _context.SaveChangesAsync();

        //await _logDB.AddAsync(log);
        //await _logDB.SaveChangesAsync();

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