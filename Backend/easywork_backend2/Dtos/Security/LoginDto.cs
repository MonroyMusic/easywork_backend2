using System.ComponentModel.DataAnnotations;

namespace easywork_backend.Dtos.Security
{
    public class LoginDto
    {

        [Display(Name = "Correo Electrónico")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public string UserName { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La {0} es requerido")]
        public string Passoword { get; set; }

    }
}
