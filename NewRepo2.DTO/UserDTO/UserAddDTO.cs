using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.DTO.UserAddDTO
{
   public class UserAddDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }        
        public string Surname { get; set; }
        public int RoleId { get; set; }
    }
}
