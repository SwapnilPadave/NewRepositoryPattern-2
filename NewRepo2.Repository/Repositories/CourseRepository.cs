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
    public interface ICourseRepository:IRepository<Course>
    {
    }
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
