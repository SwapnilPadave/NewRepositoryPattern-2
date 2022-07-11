using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.TeacherDTO;
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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Teacher>))]
        public async Task<IActionResult> GeStudentListt()
        {
            IEnumerable<Teacher> teacher = await _teacherService.GetAllTeacher();
            return Ok(teacher);
        }
        [HttpPost]
        [Produces(typeof(Teacher))]
        public async Task<IActionResult> AddSubject(TeacherAddDTO addDTO)
        {
            return Ok(await _teacherService.AddTeacher(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateSubject(TeacherUpdateDTO updateDTO)
        {
            return Ok(await _teacherService.UpdateTeacher(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            return Ok(await _teacherService.DeleteTeacher(id));
        }
    }
}
