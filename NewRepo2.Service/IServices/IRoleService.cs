using NewRepo2.DTO.RolesDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface IRoleService
    {
        Task<IEnumerable<UserRoles>> GetAllRoles();
        Task<UserRoles> GetRolesById(int id);
        Task<UserRoles> AddRoles(RolesAddDTO addDTO);
        Task<UserRoles> DeleteRoles(int id);
    }
}
