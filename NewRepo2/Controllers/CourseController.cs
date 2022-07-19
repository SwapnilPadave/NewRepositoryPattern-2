using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.CourseDTO;
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
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<Course>))]
        public async Task<IActionResult> GeCourseListt()
        {
            IEnumerable<Course> course = await _courseService.GetAllCourse();
            return Ok(course);
        }
        //[HttpGet]
        //[Route("{id}")]
        //public async Task<Course> GetCourseById(int id)
        //{
        //    return Ok(await _courseService.GetCourseById(id));
        //}
        [HttpPost]
        [Produces(typeof(Course))]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> AddCourse(CourseAddDTO addDTO)
        {
            return Ok(await _courseService.AddCourse(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> UpdateCourse(CourseUpdateDTO updateDTO)
        {
            return Ok(await _courseService.UpdateCourse(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            return Ok(await _courseService.DeleteCourse(id));
        }
    }
}
