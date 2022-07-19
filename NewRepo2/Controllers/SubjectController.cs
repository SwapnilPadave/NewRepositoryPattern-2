using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.SubjectDTO;
using NewRepo2.Model.Models;
using NewRepo2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewRepo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService _subjectService;
        public SubjectController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Subject>))]
        public async Task<IActionResult> GeSubjectListt()
        {
            IEnumerable<Subject> subject = await _subjectService.GetAllSubject();
            return Ok(subject);
        }
        [HttpPost]
        [Produces(typeof(Subject))]
        [Authorize(Policy = "Principle,Vice-Principle")]
        public async Task<IActionResult> AddSubject(SubjectAddDTO addDTO)
        {
            return Ok(await _subjectService.AddSubject(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Policy = "Principle,Vice-Principle")]
        public async Task<IActionResult> UpdateSubject(SubjectUpdateDTO updateDTO)
        {
            return Ok(await _subjectService.UpdateSubject(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = "Principle,Vice-Principle")]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            return Ok(await _subjectService.DeleteSubject(id));
        }
    }
}
