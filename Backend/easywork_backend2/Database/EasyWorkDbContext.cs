using easywork_backend.Entitys;
using easywork_backend2.Entitys;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend2.Database;

public class EasyWorkDbContext : IdentityDbContext<UserEntity>
{
    public EasyWorkDbContext(DbContextOptions<EasyWorkDbContext> options) : base(options)
    {



    }

    public DbSet<ProjectEntity> Projects { get; set; }
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<AsignationEntity> Asignations { get; set; }
    public DbSet<PriorityEntity> Priorities { get; set; }
    public DbSet<Tasks_ProjectEntity> TasksProjects { get; set; }
}