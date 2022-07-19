using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.RolesDTO;
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
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        // GET: api/<RolesController>
        [HttpGet]
        [Produces(typeof(IEnumerable<UserRoles>))]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> GeUserList()
        {
            IEnumerable<UserRoles> roles = await _roleService.GetAllRoles();
            return Ok(roles);
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<Course> GetById(int id)
        //{
        //    return Ok(await _roleService.GetRolesById(id));
        //}
        [HttpPost]
        [Produces(typeof(UserRoles))]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> Add(RolesAddDTO addDTO)
        {
            return Ok(await _roleService.AddRoles(addDTO));
        }        
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _roleService.DeleteRoles(id));
        }
    }
}
