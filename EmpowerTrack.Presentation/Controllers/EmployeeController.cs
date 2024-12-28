using EmpowerTrack.Application.ServiceInterfaces;
using EmpowerTrack.Core.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpowerTrack.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Route("employee-create")]
        [HttpPost]
        public async Task<IActionResult> EmployeeCreate([FromBody] EmployeeDto employeeDto)
        {
            return Ok("");
        }

    }
}
