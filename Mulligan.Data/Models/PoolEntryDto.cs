using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class PoolEntryDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PoolId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }

        public UserDto User { get; set; }

        public int? Score { get; set; }

        public PoolEntryDto(PoolEntry inp)
        {
            Id = inp.Id;
            UserId = inp.PoolUser.UserId;
            PoolId = inp.PoolUser.PoolId;
            Name = inp.Name;
            DateCreated = inp.DateCreated;
        }
    }
}
