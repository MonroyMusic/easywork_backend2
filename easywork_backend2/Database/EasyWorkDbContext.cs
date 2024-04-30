using easywork_backend.Entitys;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend.Database
{
    public class EasyWorkDbContext : IdentityDbContext<UserEntity>
    {

        public EasyWorkDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);

            builder.Entity<UserEntity>().ToTable("users");
            builder.Entity<IdentityRole>().ToTable("roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("users_roles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("users_claims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("users_login");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("roles_claims");
            builder.Entity<IdentityUserToken<string>>().ToTable("users_token");

        }

        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<AsignationEntity> Asignations { get; set; }
        public DbSet<PriorityEntity> Priorities { get; set; }
        public DbSet<StatesEntity> States { get; set; }
        public DbSet<Tasks_ProjectEntity> Tasks_Projects { get; set; }

    }
}
