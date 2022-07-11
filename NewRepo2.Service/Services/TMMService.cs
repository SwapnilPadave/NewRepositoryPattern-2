using NewRepo2.DTO.TMMDTO;
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
    public class TMMService:ITMMService
    {
        private readonly ITeacherMappingModelRepository _tmmrepo;
        public TMMService(ITeacherMappingModelRepository tmmrepo)
        {
            _tmmrepo = tmmrepo;
        }
        public async Task<TeacherMappingModel> AddTMM(TMMAddDTO addDTO)
        {
            try
            {
                TeacherMappingModel TMM = new TeacherMappingModel();
                TMM.TeacherId = addDTO.TeacherId;
                TMM.SubjectId = addDTO.SubjectId;
                await _tmmrepo.Add(TMM);
                return TMM;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public async Task<TeacherMappingModel> DeleteTMM(int id)
        {
            TeacherMappingModel TMM = await GetTMMById(id);
            if (TMM != null)
            {
                await _tmmrepo.Delete(TMM);
                return TMM;
            }
            return TMM;
        }       

        public async Task<IEnumerable<TeacherMappingModel>> GetTMM()
        {
            return await _tmmrepo.Get();
        }
        public async Task<TeacherMappingModel> GetTMMById(int id)
        {
            return await _tmmrepo.GetById(id);
        }
        public async Task<TeacherMappingModel> UpdateTMM(TMMUpdateDTO UpdateDTO)
        {
            try
            {
                var TMM = new TeacherMappingModel();
                TMM.Id = UpdateDTO.Id;
                TMM.TeacherId = UpdateDTO.TeacherId;
                TMM.SubjectId = UpdateDTO.SubjectId;
                TeacherMappingModel _TMM = await GetTMMById(TMM.Id);
                if (_TMM != null)
                {
                    _TMM.Id = TMM.Id;
                    _TMM.TeacherId = TMM.TeacherId;
                    _TMM.SubjectId = TMM.SubjectId;
                    await _tmmrepo.Update(_TMM);
                }
                return TMM;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
