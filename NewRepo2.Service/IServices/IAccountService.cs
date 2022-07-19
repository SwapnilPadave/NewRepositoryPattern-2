using NewRepo2.DTO.RolesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface IAccountService
    {
        Task<RoleDTO> login(string username, string password);
    }
}
