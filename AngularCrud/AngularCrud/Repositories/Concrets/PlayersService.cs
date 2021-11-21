using AngularCrud.Data;
using AngularCrud.Models;
using AngularCrud.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrud.Repositories.Concrets
{
    public class PlayersService : IPlayersService
    {
        private readonly FootballDbContext _context;

        public PlayersService(FootballDbContext context)
        {
            _context = context;
        }
        public async Task<Players> CreatePlayer(Players player)
        {
            _context.GetPlayers.Add(player);
            await _context.SaveChangesAsync();
            return player;
        }

        public async Task DeletePlayer(Players player)
        {
            _context.GetPlayers.Remove(player);
            await _context.SaveChangesAsync();
        }
        public async Task<Players> GetPlayerById(int id)
        {
            return await _context.GetPlayers.Include(x => x.PositionId).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<IEnumerable<Players>> GetPlayersList()
        {
            return await _context.GetPlayers.Include(x => x.PositionId).ToListAsync();
        }
        public async Task UpdatePlayer(Players player)
        {
            _context.GetPlayers.Update(player);
            await _context.SaveChangesAsync();
        }
    }
}
