using AdvanceAPI.BLL.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IProjectManager _projectManager;
        public ProjectController(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _projectManager.GetAllProjects();

            return Ok(result.Data);
        }

        [HttpGet("Get/{id:int}")]
        public async Task<IActionResult> GetProjectById(int id)
        {
            var result = await _projectManager.GetProjectById(id);

            return Ok(result.Data);
        }
    }
}
