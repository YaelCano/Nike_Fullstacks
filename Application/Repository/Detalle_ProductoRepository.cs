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
    public class Detalle_ProductoRepository : GenericRepository<Detalle_Producto> , IDetalle_Producto 
    { 
        public Nike_FullstacksContext _context { get; set; } 
        public Detalle_ProductoRepository(Nike_FullstacksContext context) : base(context) 
        { 
            _context = context; 
        } 
    } 
} 
