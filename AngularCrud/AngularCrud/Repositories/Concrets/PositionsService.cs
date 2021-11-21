using AngularCrud.Data;
using AngularCrud.Models;
using AngularCrud.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCrud.Repositories.Concrets
{
    public class PositionsService : IPositionService
    {
        private readonly FootballDbContext _context;
        public PositionsService(FootballDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Positions>> GetPositionsList()
        {
            return await _context.GetPostitions.OrderBy(x => x.DisplayOrder).ToListAsync();
        }
    }
}
