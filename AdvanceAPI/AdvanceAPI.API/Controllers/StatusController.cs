using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusManager _statusManager;
        public StatusController(IStatusManager statusManager)
        {
            _statusManager = statusManager;
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetStatusById(int id)
        {
            var result = await _statusManager.GetStatusById(id);

            return Ok(result.Data);
        }
    }
}
