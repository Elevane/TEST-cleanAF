using cleanAf.Application.Models;
using cleanAf.Application.Services;
using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cleanAf.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly UserService _service;
        public UsersController(UserService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Result<List<UserDto>> res = await _service.GetAll();
            if (res.IsFailure)
                return BadRequest();
            return Ok(res.Value);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateUserDto user)
        {
            Result res = await _service.Create(user);
            if (res.IsFailure)
                return BadRequest();
            return Ok();
        }
    }
}
