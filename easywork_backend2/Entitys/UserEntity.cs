using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easywork_backend.Entitys
{
    public class UserEntity : IdentityUser
    {

        
        [StringLength(50)]
        public string FirstName { get; set; }

        
        [StringLength(50)]
        public string LastName { get; set; }

    }
}
