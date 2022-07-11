using NewRepo2.DTO.SubjectDTO;
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
    public class SubjectService:ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }
        public async Task<Subject> AddSubject(SubjectAddDTO addDTO)
        {
            try
            {
                var subject = new Subject();
                subject.SubjectName = addDTO.SubjectName;
                subject.CourseId = addDTO.CourseId;
                await _subjectRepository.Add(subject);
                return subject;
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }
        public async Task<Subject> DeleteSubject(int id)
        {
            Subject subject = await GetSubjectById(id);
            if (subject != null)
            {
                await _subjectRepository.Delete(subject);
                return subject;
            }
            return subject;
        }
        public async Task<IEnumerable<Subject>> GetAllSubject()
        {
            return await _subjectRepository.Get();
        }
        public async Task<Subject> GetSubjectById(int id)
        {
            return await _subjectRepository.GetById(id);
        }
        public async Task<Subject> UpdateSubject(SubjectUpdateDTO updateDTO)
        {
            try
            {
                var subject = new Subject();
                subject.SubjectId = updateDTO.SubjectId;
                subject.SubjectName = updateDTO.SubjectName;
                subject.CourseId = updateDTO.CourseId;
                Subject _subject = await _subjectRepository.GetById(subject.SubjectId);
                if (_subject != null)
                {
                    _subject.SubjectId = subject.SubjectId;
                    _subject.SubjectName = subject.SubjectName;
                    _subject.CourseId = subject.CourseId;
                }
                return subject;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
