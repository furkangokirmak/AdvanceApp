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

        [HttpGet("GetEmployeeAdvances/{id:int}")]
        public async Task<IActionResult> GetEmployeeAdvances(int id)
        {
            var result = await _advanceManager.GetEmployeeAdvances(id);

            return Ok(result.Data);
        }

        [HttpGet("GetAdvanceHistories/{id:int}")]
        public async Task<IActionResult> GetAdvanceHistories(int id)
        {
            var result = await _advanceManager.GetAdvanceHistory(id);

            return Ok(result.Data);
        }

        [HttpGet("GetAdvance/{id:int}")]
        public async Task<IActionResult> GetAdvance(int id)
        {
            var result = await _advanceManager.GetAdvanceById(id);

            return Ok(result.Data);
        }

    }
}
