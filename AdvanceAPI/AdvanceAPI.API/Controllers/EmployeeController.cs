using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private IEmployeeManager _userManager;
		public EmployeeController(IEmployeeManager userManager)
		{
			_userManager = userManager;
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAll()
		{
			var result = await _userManager.GetAllEmployees();

			return Ok(result.Data);
		}
	}
}
