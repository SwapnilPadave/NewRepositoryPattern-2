using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.StudentDTO;
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
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Student>))]
        public async Task<IActionResult> GeStudentListt()
        {
            IEnumerable<Student> student = await _studentService.GetAllStudent();
            return Ok(student);
        }
        [HttpPost]
        [Produces(typeof(Student))]
        public async Task<IActionResult> AddStudent(StudentAddDTO addDTO)
        {
            return Ok(await _studentService.AddStudent(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateStudent(StudentUpdateDTO updateDTO)
        {
            return Ok(await _studentService.UpdateStudent(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            return Ok(await _studentService.DeleteStudent(id));
        }
    }
}
