using NewRepo2.DTO.CourseDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourse();
        Task<Course> GetCourseById(int id);
        Task<Course> AddCourse(CourseAddDTO addDTO);
        Task<Course> UpdateCourse(CourseUpdateDTO updateDTO);
        Task<Course> DeleteCourse(int id);
    }
}
