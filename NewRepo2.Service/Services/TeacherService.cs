using NewRepo2.DTO.TeacherDTO;
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
    public class TeacherService:ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public async Task<Teacher> AddTeacher(TeacherAddDTO addDTO)
        {
            try
            {
                Teacher teacher = new Teacher();
                teacher.TeacherName = addDTO.TeacherName;
                await _teacherRepository.Add(teacher);
                return teacher;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Teacher> DeleteTeacher(int id)
        {
            Teacher teacher = await GetTeacherById(id);
            if (teacher != null)
            {
                await _teacherRepository.Delete(teacher);
                return teacher;
            }
            return teacher;
        }
        public async Task<IEnumerable<Teacher>> GetAllTeacher()
        {
            return await _teacherRepository.Get();
        }
        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _teacherRepository.GetById(id);
        }
        public async Task<Teacher> UpdateTeacher(TeacherUpdateDTO updateDTO)
        {
            try
            {
                var teacher = new Teacher();
                teacher.TeacherId = updateDTO.TeacherId;
                teacher.TeacherName = updateDTO.TeacherName;
                Teacher _teacher = await GetTeacherById(teacher.TeacherId);
                if (_teacher != null)
                {
                    _teacher.TeacherId = teacher.TeacherId;
                    _teacher.TeacherName = teacher.TeacherName;
                    await _teacherRepository.Update(_teacher);
                }
                return teacher;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
