using AngularCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCrud.Repositories.Abstracts
{
    public interface IPositionService
    {
        Task<IEnumerable<Positions>> GetPositionsList();
    }
}
