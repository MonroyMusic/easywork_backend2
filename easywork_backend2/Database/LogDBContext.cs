using easywork_backend2.Entitys.Log;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend2.Database
{
    public class LogDBContext : DbContext
    {

        public LogDBContext(DbContextOptions<LogDBContext> options) : base(options) 
        {}

        public DbSet<LogsEntity> Logs { get; set; }

    }
}
