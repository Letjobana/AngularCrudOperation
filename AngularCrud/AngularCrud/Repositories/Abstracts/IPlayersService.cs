using AngularCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularCrud.Repositories.Abstracts
{
    public interface IPlayersService
    {
        Task<IEnumerable<Players>> GetPlayersList();
        Task<Players> GetPlayerById(int id);
        Task<Players> CreatePlayer(Players player);
        Task UpdatePlayer(Players player);
        Task DeletePlayer(Players player);
    }
}
