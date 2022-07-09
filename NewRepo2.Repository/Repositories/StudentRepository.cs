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
    public interface IStudentRepository : IRepository<Student>
    {
            
    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
