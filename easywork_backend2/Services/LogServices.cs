using easywork_backend2.Database;
using easywork_backend2.Entitys.Log;
using easywork_backend2.Services.Interfaces;

namespace easywork_backend2.Services
{
    public class LogServices : ILogServices
    {
        private readonly LogDBContext _logDB;
        private readonly string _USER_ID = "";

        public LogServices(LogDBContext logDB, IHttpContextAccessor httpContextAccessor)
        {

            _logDB = logDB;
            var idClaim = httpContextAccessor.HttpContext.User.Claims.Where(x => x.Type == "UserId").FirstOrDefault();
            _USER_ID = idClaim?.Value;

        }

        public async Task CreateLogAsync(string action)
        {

            var log = new LogEntity()
            {

                Id = Guid.NewGuid(),
                Action = action,
                Time = DateTime.UtcNow,
                User_Id = _USER_ID,

            };

            await _logDB.AddAsync(log);

            await _logDB.SaveChangesAsync();

        }

        public async Task CreateLogAsync(string action, string user_id)
        {

            var log = new LogEntity()
            {

                Id = Guid.NewGuid(),
                Action = action,
                Time = DateTime.UtcNow,
                User_Id = user_id

            };

            await _logDB.AddAsync(log);

            await _logDB.SaveChangesAsync();

        }

    }
}
