using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NewRepo2.DTO.LoginDTO;
using NewRepo2.DTO.RolesDTO;
using NewRepo2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewRepo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _config;

        public LoginController(IAccountService accountService, ITokenService tokenService, IConfiguration config)
        {
            _accountService = accountService;
            _tokenService = tokenService;
            _config = config;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(Login LoginDTO)
        {
            RoleDTO _login = await _accountService.login(LoginDTO.UserName, LoginDTO.Password);

            if (_login == null)
            {
                return Unauthorized("Invalid Credentials");
            }
            var token = _tokenService.CreateToken(_login);
            return Ok(token);
        }
    }
}
