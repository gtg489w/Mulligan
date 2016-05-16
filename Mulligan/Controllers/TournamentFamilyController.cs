using Mulligan.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mulligan.Controllers
{
    public class TournamentFamilyController : BaseApiController
    {
        [HttpGet]
        [Route("api/TournamentFamily/Active")]
        public IHttpActionResult GetActiveTournamentFamilies()
        {
            using (var db = DataContext)
            {
                var tournFams = db.TournamentFamilies
                                    .Where(x => x.Tournaments
                                                .Any(y => y.StartDate <= DateTime.UtcNow && y.EndDate >= DateTime.UtcNow))
                                    .Select(x => new TournamentFamilyDto(x) { Tournaments = x.Tournaments.Where(y => y.StartDate <= DateTime.UtcNow && y.EndDate >= DateTime.UtcNow).Select(y => new TournamentDto(y)).ToList() }).ToList();
                return Ok(tournFams);
            }
        }
    }
}
