using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCrud.Data
{
    public class FootballDbContext:DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {

        }
        
    }
}
