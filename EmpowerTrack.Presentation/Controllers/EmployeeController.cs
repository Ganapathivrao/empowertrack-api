using EmpowerTrack.Application.ServiceInterfaces;
using EmpowerTrack.Core.Dto.Read;
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

        [Route("save-employee-details")]
        [HttpPost]
        public async Task<IActionResult> SaveEmployeeDetails([FromBody] EmployeeReadDto employeeDto)
        {
            return Ok("");
        }

    }
}
