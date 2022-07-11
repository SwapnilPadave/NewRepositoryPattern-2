using NewRepo2.DTO.SubjectDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface ISubjectService
    {
        Task<IEnumerable<Subject>> GetAllSubject();
        Task<Subject> GetSubjectById(int id);
        Task<Subject> AddSubject(SubjectAddDTO addDTO);
        Task<Subject> UpdateSubject(SubjectUpdateDTO updateDTO);
        Task<Subject> DeleteSubject(int id);
    }
}
