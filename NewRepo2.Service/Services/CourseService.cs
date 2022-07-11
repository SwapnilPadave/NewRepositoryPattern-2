using NewRepo2.DTO.CourseDTO;
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
    public class CourseService :ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<Course> AddCourse(CourseAddDTO addDTO)
        {
            try
            {
                var course = new Course();
                course.CourseName = addDTO.CourseName;
                await _courseRepository.Add(course);
                return course;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Course> DeleteCourse(int id)  
        {
            Course course = await GetCourseById(id);
            if(course != null)
            {
                await _courseRepository.Delete(course);
                return course;
            }
            return course;
        }
        public async Task<IEnumerable<Course>> GetAllCourse()
        {
            return await _courseRepository.Get();
        }

        public async Task<Course> GetCourseById(int id)
        {
            return await _courseRepository.GetById(id);
        }
        public async Task<Course> UpdateCourse(CourseUpdateDTO updateDTO)
        {
            try
            {
                var course = new Course();
                
                course.CourseName = updateDTO.CourseName;
                Course _course = await GetCourseById(course.CourseId);
                if (_course != null)
                {
                   
                    _course.CourseName = course.CourseName;
                    await _courseRepository.Update(_course);
                }
                return course;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
