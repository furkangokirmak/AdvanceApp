using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TitleController : ControllerBase
	{
		private ITitleManager _titleManager;
		public TitleController(ITitleManager titleManager)
		{
			_titleManager = titleManager;
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAll()
		{
			var result = await _titleManager.GetAllTitles();

			return Ok(result.Data);
		}
	}
}
