using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using Api.Repository; 
using Domain.Entities; 
using Domain.Interfaces; 
using Microsoft.EntityFrameworkCore; 
using Persistence.Data; 

namespace Application.Repository 
{ 
    public class UsuarioRolesRepository : GenericRepository<UsuarioRoles> , IUsuarioRoles 
    { 
        public Nike_FullstacksContext _context { get; set; } 
        public UsuarioRolesRepository(Nike_FullstacksContext context) : base(context) 
        { 
            _context = context; 
        } 
    } 
} 
