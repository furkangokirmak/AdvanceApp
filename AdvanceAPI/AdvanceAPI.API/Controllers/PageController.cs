using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageManager _pageManager;

        public PageController(IPageManager pageManager)
        {
            _pageManager = pageManager;
        }

        [HttpGet("GetPagesWithSelectAuthorization/{id:int}")]
        public async Task<IActionResult> GetPagesWithSelectAuthorization(int id)
        {
            var result = await _pageManager.GetPagesWithSelectAuthorization(id);

            return Ok(result.Data);
        }
    }
}
