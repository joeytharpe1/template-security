using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace tweet.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
         
    }
}