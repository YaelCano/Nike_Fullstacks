using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshToken
    {
        public Nike_FullstacksContext _context { get; set; } 
        public RefreshTokenRepository(Nike_FullstacksContext context) : base(context) 
        { 
            _context = context; 
        } 
    }
}