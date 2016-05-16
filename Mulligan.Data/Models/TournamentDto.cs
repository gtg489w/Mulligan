using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class TournamentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TournamentFamilyId { get; set; }
        public bool IsActive { get; set; }

        public List<PlayerDto> Players { get; set; }

        public TournamentDto(Tournament inp)
        {
            Id = inp.Id;
            Name = inp.Name;
            StartDate = inp.StartDate;
            EndDate = inp.EndDate;
            TournamentFamilyId = inp.TournamentFamilyId;
            IsActive = StartDate <= DateTime.UtcNow && DateTime.UtcNow <= EndDate;
        }
    }
}
