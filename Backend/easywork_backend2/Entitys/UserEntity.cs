﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace easywork_backend2.Entitys
{
    public class UserEntity : IdentityUser
    {
        [StringLength(50)] public string FirstName { get; set; }

        [StringLength(50)] public string LastName { get; set; }
    }
}