
namespace easywork_backend2.Services.Interfaces
{
    public interface ILogServices
    {
        Task CreateLogAsync(string action);
        Task CreateLogAsync(string action, string user_id);
    }
}
