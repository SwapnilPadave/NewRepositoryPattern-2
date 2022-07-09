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
    public interface ITeacherMappingModelRepository : IRepository<TeacherMappingModel>
    {

    }
    public class TeacherMappingModelRepository : Repository<TeacherMappingModel>, ITeacherMappingModelRepository
    {
        public TeacherMappingModelRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
