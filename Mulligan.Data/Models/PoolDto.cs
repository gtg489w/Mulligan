using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class PoolDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? EntryFee { get; set; }
        public int? EntryLimit { get; set; }
        public string Passcode { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public int TournamentId { get; set; }

        public List<PoolEntryDto> Entries { get; set; }

        public PoolDto(Pool inp)
        {
            Id = inp.Id;
            Name = inp.Name;
            Description = inp.Description;
            EntryFee = inp.EntryFee;
            EntryLimit = inp.EntryLimit;
            Passcode = inp.Passcode;
            DateCreated = inp.DateCreated;
            IsActive = inp.IsActive;
            TournamentId = inp.TournamentId;
        }
    }
}
