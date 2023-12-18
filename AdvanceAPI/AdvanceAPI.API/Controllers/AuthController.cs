using AdvanceAPI.BLL.Abstract;
using AdvanceAPI.CORE.Utilities;
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

            return Ok(token.Data);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] EmployeeRegisterDTO dto)
        {
            var state = await _authManager.Register(dto);

            return Ok(state);
        }

		[HttpPost("ForgotPassword")]
		public async Task<IActionResult> ForgotPassword(EmployeeSelectDTO dto)
		{
			var state = await _authManager.ForgotPassword(dto);

			return Ok(state);
		}

		[HttpGet("ResetPassword/{token}")]
		public async Task<IActionResult> ResetPassword(string token)
		{
			var result = await _authManager.GetEmployeeByResetToken(token);

			return Ok(result.Data);
		}

        [HttpPost("SetPassword")]
        public async Task<IActionResult> SetPassword([FromBody] EmployeeLoginDTO employeeLoginDTO)
        {
            var result = await _authManager.SetPassword(employeeLoginDTO);

            return Ok(result.Data);
        }
    }
}
