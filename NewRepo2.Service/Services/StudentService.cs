using NewRepo2.DTO.StudentDTO;
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
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> AddStudent(StudentAddDTO addDTO)
        {
            try
            {
                var student = new Student();
                student.FullName = addDTO.FullName;
                student.Email = addDTO.Email;
                student.CourseId = addDTO.CourseId;
                await _studentRepository.Add(student);
                return student;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Student> DeleteStudent(int id)
        {
            Student student = await GetStudentById(id);
            if (student != null)
            {
                await _studentRepository.Delete(student);
                return student;
            }
            return student;
        }
        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            return await _studentRepository.Get();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _studentRepository.GetById(id);
        }
        public async Task<Student> UpdateStudent(StudentUpdateDTO updateDTO)
        {
            try
            {
                var student = new Student();
                student.StudentId = updateDTO.StudentId;
                student.FullName = updateDTO.FullName;
                student.Email = updateDTO.Email;
                Student _student = await _studentRepository.GetById(student.StudentId);
                if (_student != null)
                {
                    _student.StudentId = student.StudentId;
                    _student.FullName = student.FullName;
                    _student.Email = student.Email;
                    _student.CourseId = student.CourseId;
                    await _studentRepository.Update(_student);
                }
                return student;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
