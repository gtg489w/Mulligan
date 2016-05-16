using Mulligan.Data;
using Mulligan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mulligan.Controllers
{
    public class TournamentController : BaseApiController
    {
        [HttpGet]
        [Route("api/Tournament/Active")]
        public IHttpActionResult GetActiveTournaments()
        {
            using (var Db = DataContext)
            {
                return Ok(Db.Tournaments.Where(x => x.StartDate <= DateTime.UtcNow && x.EndDate >= DateTime.UtcNow).Select(x => new TournamentDto(x)).ToList());
            }
        }

        [HttpGet]
        [Route("api/Tournament/{id}")]
        public IHttpActionResult GetTournament(int id)
        {
            using (var db = DataContext)
            {
                var tourn = db.Tournaments.FirstOrDefault(x => x.Id == id);

                if (tourn == null)
                    return NotFound();

                return Ok(new TournamentDto(tourn) { Players = tourn.TournamentPlayers.Select(x => new PlayerDto(x)).ToList() });
            }
        }
    }
}