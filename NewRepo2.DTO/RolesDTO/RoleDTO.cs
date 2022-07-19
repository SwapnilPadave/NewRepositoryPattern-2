using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.DTO.RolesDTO
{
    public class RoleDTO:UserRoles
    {
        public string UserName { get; set; }
        public string password { get; set; }
    }
}
