using AutoMapper;
using easywork_backend.Dtos;
using easywork_backend2.Database;
using easywork_backend2.Dtos.Log;
using easywork_backend2.Dtos.Project;
using easywork_backend2.Entitys.Log;
using easywork_backend2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace easywork_backend2.Services
{
    public class LogServices : ILogServices
    {
        private readonly LogDBContext _logDB;
        private readonly IMapper _mapper;
        private readonly string _USER_ID = "";

        public LogServices(LogDBContext logDB, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {

            _logDB = logDB;
            _mapper = mapper;
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

        public async Task<ResponseDto<List<LogDto>>> GetAllAsync()
        {

            var logs = await _logDB.Logs
            .Where(x => x.User_Id == _USER_ID)
            .ToListAsync();

            var logsDtos = _mapper.Map<List<LogDto>>(logs);

            return new ResponseDto<List<LogDto>>
            {
                Data = logsDtos,
                StatusCode = 200
            };

        }

    }
}
