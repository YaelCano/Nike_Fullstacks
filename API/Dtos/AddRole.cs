using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class AddRole
    {
        [Required]
        public string ? Username { get; set; }
        [Required]
        public string ? Password { get; set; }
        [Required]
        public string ? Rol { get; set; }
    }
}