using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Username {get; set;}
        public string Email {get; set;}
        public string  Password {get; set;}
        public ICollection<Rol> Rols {get; set;}
        public ICollection<UsuarioRoles> UsuarioRoles {get; set;}
        public ICollection<RefreshToken> RefreshTokens {get; set;}
    }
}
