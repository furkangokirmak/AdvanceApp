using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BusinessUnitController : ControllerBase
	{
		private IBusinessUnitManager _businessUnitManager;
        public BusinessUnitController(IBusinessUnitManager businessUnitManager)
        {
			_businessUnitManager = businessUnitManager;
		}

        [HttpGet("GetAll")]
		public async Task<IActionResult> GetAll()
		{
			var result = await _businessUnitManager.GetAllBusinessUnits();

			return Ok(result.Data);
		}
	}
}
