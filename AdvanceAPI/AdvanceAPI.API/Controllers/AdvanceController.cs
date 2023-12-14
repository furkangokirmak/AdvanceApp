using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.DTOs.Advance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceController : ControllerBase
    {
        private IAdvanceManager _advanceManager;
        public AdvanceController(IAdvanceManager advanceManager)
        {
            _advanceManager = advanceManager;
        }

        [HttpPost("AddAdvance")]
        public async Task<IActionResult> AddAdvance(AdvanceInsertDTO advanceInsertDTO)
        {
            var result = await _advanceManager.AddAdvance(advanceInsertDTO);

            return Ok(result.Data);
        }

        [HttpGet("GetEmployeeAdvances")]
        public async Task<IActionResult> GetEmployeeAdvances(int employeeId)
        {
            var result = await _advanceManager.GetEmployeeAdvances(employeeId);

            return Ok(result.Data);
        }

    }
}
