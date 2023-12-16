using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.DTOs.Advance;
using AdvanceAPI.DTOs.AdvanceHistory;
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

        [HttpGet("GetPendingAdvances/{id:int}")]
        public async Task<IActionResult> GetPendingAdvances(int id)
        {
            var result = await _advanceManager.GetPendingAdvance(id);

            return Ok(result.Data);
        }

        [HttpGet("GetPendingPaymentDateAdvance")]
        public async Task<IActionResult> GetPendingPaymentDateAdvance()
        {
            var result = await _advanceManager.GetPendingPaymentDateAdvance();

            return Ok(result.Data);
        }

        [HttpPost("AdvanceRequestAccept")]
        public async Task<IActionResult> AdvanceRequestAccept(AdvanceHistorySelectDTO dto)
        {
            var result = await _advanceManager.AdvanceRequestAccept(dto);

            return Ok(result.Data);
        }

        [HttpPost("AdvanceRequestReject")]
        public async Task<IActionResult> AdvanceRequestReject(AdvanceHistorySelectDTO dto)
        {
            var result = await _advanceManager.AdvanceRequestReject(dto);

            return Ok(result.Data);
        }

		[HttpPost("AdvanceRequestSetPaymentDate")]
		public async Task<IActionResult> AdvanceRequestSetPaymentDate(AdvanceHistorySelectDTO dto)
		{
			var result = await _advanceManager.AdvanceRequestSetPaymentDate(dto);

			return Ok(result.Data);
		} 

        [HttpPost("AdvanceRequestReceipt")]
        public async Task<IActionResult> AdvanceRequestReceipt(AdvanceSelectDTO dto)
        {
            var result = await _advanceManager.AdvanceRequestReceipt(dto);

            return Ok(result.Data);
        }

        [HttpGet("GetPendingReceipt")]
        public async Task<IActionResult> GetPendingReceipt()
        {
            var result = await _advanceManager.GetPendingReceipt();

            return Ok(result.Data);
        }
    }
}
