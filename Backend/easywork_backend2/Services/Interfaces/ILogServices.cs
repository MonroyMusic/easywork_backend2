
using easywork_backend.Dtos;
using easywork_backend2.Dtos.Log;

namespace easywork_backend2.Services.Interfaces
{
    public interface ILogServices
    {
        Task CreateLogAsync(string action);
        Task CreateLogAsync(string action, string user_id);
        Task<ResponseDto<List<LogDto>>> GetAllAsync();
    }
}
