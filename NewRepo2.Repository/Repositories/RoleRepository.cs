using NewRepo2.Model.Models;
using NewRepo2.Repository.DbContextFolder;
using NewRepo2.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Repository.Repositories
{
    public interface IRoleRepository : IRepository<UserRoles>
    {

    }
    public class RoleRepository:Repository<UserRoles>,IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
