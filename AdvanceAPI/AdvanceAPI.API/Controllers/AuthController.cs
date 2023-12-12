using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.DTOs.Employee;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthManager _authManager;

        public AuthController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] EmployeeLoginDTO dto)
        {
            var token = await _authManager.Login(dto);

            return Ok(token);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] EmployeeRegisterDTO dto)
        {
            var state = await _authManager.Register(dto);

            return Ok(state);
        }
    }
}
