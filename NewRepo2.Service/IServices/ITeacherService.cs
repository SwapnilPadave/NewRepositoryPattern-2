using NewRepo2.DTO.TeacherDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetAllTeacher();
        Task<Teacher> GetTeacherById(int id);
        Task<Teacher> AddTeacher(TeacherAddDTO addDTO);
        Task<Teacher> UpdateTeacher(TeacherUpdateDTO updateDTO);
        Task<Teacher> DeleteTeacher(int id);
    }
}
