using EmpowerTrack.Application.ServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpowerTrack.Presentation.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SidePanelController : ControllerBase
    {
        private readonly ISidePanelService _sidePanelService;
        public SidePanelController(ISidePanelService sidePanelService)
        {
            _sidePanelService = sidePanelService;
        }
        [Route("get-sidepael-details")]
        [HttpGet]
        public async Task<IActionResult> GetModulesAndSubModulesAsync()
        {

            var result = await _sidePanelService.GetModuleDetailsAsync();
            return Ok(result);
        }
    }
}
