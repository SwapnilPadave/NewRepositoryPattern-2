using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewRepo2.DTO.UserAddDTO;
using NewRepo2.DTO.UserDTO;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> getUserList()
        {
            IEnumerable<UserModel> user = await _userService.GetAllUsers();
            return Ok(user);
        }
        [AllowAnonymous]
        [HttpPost]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> AddUser(UserAddDTO addDTO)
        {
            return Ok(await _userService.AddUser(addDTO));
        }
        [HttpPut]
        [Route("{id}")]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> UpdateUser(UserUpdateDTO updateDTO)
        {
            return Ok(await _userService.UpdateUser(updateDTO));
        }
        [HttpDelete]
        [Route("{id}")]
        [Authorize(Policy = "Principle")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return Ok(await _userService.DeleteUser(id));
        }
    }
}
