using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.TMMDTO;
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
    public class TeacherMatchingModelController : ControllerBase
    {
        private readonly ITMMService _tMMService;
        public TeacherMatchingModelController(ITMMService tMMService)
        {
            _tMMService = tMMService;
        }
        [HttpGet]
        [Produces(typeof(IEnumerable<TeacherMappingModel>))]
        public async Task<IActionResult> GeTMMListt()
        {
            IEnumerable<TeacherMappingModel> tmm = await _tMMService.GetTMM();
            return Ok(tmm);
        }
        [HttpPost]
        [Produces(typeof(TeacherMappingModel))]
        public async Task<IActionResult> AddTMM(TMMAddDTO addDTO)
        {
            return Ok(await _tMMService.AddTMM(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateSubject(TMMUpdateDTO updateDTO)
        {
            return Ok(await _tMMService.UpdateTMM(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteTMM(int id)
        {
            return Ok(await _tMMService.DeleteTMM(id));
        }
    }
}
