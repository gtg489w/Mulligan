using Mulligan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mulligan.Controllers
{
    public class PoolController : BaseApiController
    {
        [HttpGet]
        [Route("api/Pool/{id}/Leaderboard")]
        public IHttpActionResult GetPoolLeaderboard(int id)
        {
            using (var db = DataContext)
            {
                var pool = db.Pools.FirstOrDefault(x => x.Id == id);

                if (pool == null)
                    return NotFound();

                var retDto = new PoolDto(pool);

                var entries = pool.PoolUsers.SelectMany(x => x.PoolEntries).Select(x => new PoolEntryDto(x) { Score = x.PoolEntryTournamentPlayers.Where(y => y.TournamentPlayer.IsActive).Sum(y => y.TournamentPlayer.Score), User = new UserDto(x.PoolUser.User) }).ToList();

                retDto.Entries = entries.OrderBy(x => x.Score).ToList();

                return Ok(retDto);
            }
        }

    }
}
