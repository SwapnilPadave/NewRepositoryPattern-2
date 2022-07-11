using NewRepo2.DTO.TMMDTO;
using NewRepo2.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepo2.Service.IServices
{
    public interface ITMMService
    {
        Task<IEnumerable<TeacherMappingModel>> GetTMM();
        Task<TeacherMappingModel> GetTMMById(int id);
        Task<TeacherMappingModel> AddTMM(TMMAddDTO addDTO);
        Task<TeacherMappingModel> UpdateTMM(TMMUpdateDTO updateDTO);
        Task<TeacherMappingModel> DeleteTMM(int id);
    }
}
