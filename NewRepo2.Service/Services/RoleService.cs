using NewRepo2.DTO.RolesDTO;
using NewRepo2.Model.Models;
using NewRepo2.Repository.Repositories;
using NewRepo2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.Services
{
    public class RoleService :IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<UserRoles> AddRoles(RolesAddDTO addDTO)
        {
            try
            {
                var role = new UserRoles();
                role.RoleName= addDTO.RoleName;
                await _roleRepository.Add(role);
                return role;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UserRoles> DeleteRoles(int id)
        {
            UserRoles role = await GetRolesById(id);
            if (role != null)
            {
                await _roleRepository.Delete(role);
                return role;
            }
            return role;
        }

        public async Task<IEnumerable<UserRoles>> GetAllRoles()
        {
            return await _roleRepository.Get();
        }

        public async Task<UserRoles> GetRolesById(int id)
        {
            return await _roleRepository.GetById(id);
        }
    }
}
