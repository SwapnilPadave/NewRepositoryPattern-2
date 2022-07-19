using Microsoft.EntityFrameworkCore;
using NewRepo2.DTO.LoginDTO;
using NewRepo2.DTO.RolesDTO;
using NewRepo2.Repository.DbContextFolder;
using NewRepo2.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Repository.Repositories
{
    public interface IAccountRepository : IRepository<Login>
    {
        Task<RoleDTO> login(string username, string password);
    }
    public class AccountRepository : Repository<Login>, IAccountRepository
    {
        public AccountRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<RoleDTO> login(string username, string password)
        {
            var loginDTO = await (from u in _context.UserModels
                                  join r in _context.UserRole on
                                  u.RoleId equals r.RoleId
                                  where u.Username == username & u.Password == password
                                  select new RoleDTO
                                  {
                                      UserName = u.Username,
                                      password = u.Password,
                                      RoleId = u.RoleId,
                                      RoleName = r.RoleName

                                  }).FirstOrDefaultAsync();

            return loginDTO;
        }
    }
}
