using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class TournamentFamilyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TournamentDto> Tournaments { get; set; }

        public TournamentFamilyDto(TournamentFamily inp)
        {
            Id = inp.Id;
            Name = inp.Name;
        }
    }
}
