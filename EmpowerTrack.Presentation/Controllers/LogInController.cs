using EmpowerTrack.Application.ServiceInterfaces;
using EmpowerTrack.Core.Dto;
using EmpowerTrack.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpowerTrack.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly IUserService _userService;
        public LogInController(IUserService userService) 
        { 
            _userService = userService;
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> ValidateCredentialsAsync([FromBody] UserDto user)
        {
            var res=await _userService.ValidateCredentialsAsync(user);
            return Ok(res);
        }
    }
}
