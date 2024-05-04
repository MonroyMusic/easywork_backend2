using System.ComponentModel.DataAnnotations;

namespace easywork_backend2.Dtos.Log
{
    public class CreateLogDto
    {

        public Guid Id { get; set; }

        public string Action { get; set; }

        public DateTime Time { get; set; }

    }
}
