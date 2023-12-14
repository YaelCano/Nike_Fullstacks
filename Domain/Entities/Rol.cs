using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rol : BaseEntity
    {
        public string Nombre {get; set;}
        public ICollection<Usuario> Usuarios {get; set;}
        public ICollection<UsuarioRoles> UsuarioRoles {get; set;}
    }
}
