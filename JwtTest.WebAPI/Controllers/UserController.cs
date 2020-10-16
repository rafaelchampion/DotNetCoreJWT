using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwtTest.Domain.Models;
using JwtTest.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTest.WebAPI.Controllers
{
    [Route("users")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = UserService.GetUser(model.Username, model.Password);
            if (user != null)
            {
                var token = TokenService.GenerateToken(user);
                return new { user = user, token = token };
            }
            return NotFound(new { message = "Usuário não encontrado" });
        }
    }
}
