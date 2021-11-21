using AngularCrud.Models;
using AngularCrud.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrud.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersService _playerService;

        public PlayersController(IPlayersService playerService)
        {
            _playerService = playerService;
        }

        // GET: api/Players
        [HttpGet]
        public async Task<IEnumerable<Players>> Get()
        {
            try
            {
                return await _playerService.GetPlayersList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        // GET: api/Players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Players>> Get(int id)
        {
            try
            {
                var player = await _playerService.GetPlayerById(id);

                if (player == null)
                {
                    return NotFound();
                }

                return Ok(player);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // POST: api/Players
        [HttpPost]
        public async Task<ActionResult<Players>> Post(Players player)
        {
            await _playerService.CreatePlayer(player);

            return CreatedAtAction("Post", new { id = player.Id }, player);
        }

        // PUT: api/Players/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Players player)
        {
            try
            {
                if (id != player.Id)
                {
                    return BadRequest("Not a valid player id");
                }

                await _playerService.UpdatePlayer(player);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }

        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Not a valid player id");

                var player = await _playerService.GetPlayerById(id);
                if (player == null)
                {
                    return NotFound();
                }

                await _playerService.DeletePlayer(player);

                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
