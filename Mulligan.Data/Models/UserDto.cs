using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulligan.Data.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public DateTime DateCreated { get; set; }

        public UserDto(User inp)
        {
            Id = inp.Id;
            FirstName = inp.FirstName;
            LastName = inp.LastName;
            UserName = inp.UserName;
            DateCreated = inp.DateCreated;
        }
    }
}
