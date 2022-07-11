using NewRepo2.DTO.StudentDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentById(int id);
        Task<Student> AddStudent(StudentAddDTO addDTO);
        Task<Student> UpdateStudent(StudentUpdateDTO updateDTO);
        Task<Student> DeleteStudent(int id);
    }
}
