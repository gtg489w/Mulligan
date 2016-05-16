using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int? Tier { get; set; }
        public int? Score { get; set; }
        public bool? IsActive { get; set; }

        public PlayerDto(Player inp)
        {
            Id = inp.Id;
            FirstName = inp.FirstName;
            LastName = inp.LastName;
            DateOfBirth = inp.DateOfBirth;
        }

        public PlayerDto(TournamentPlayer inp)
        {
            Id = inp.PlayerId;
            FirstName = inp.Player.FirstName;
            LastName = inp.Player.LastName;
            DateOfBirth = inp.Player.DateOfBirth;
            Tier = inp.Tier;
            Score = inp.Score;
            IsActive = inp.IsActive;
        }
    }
}
