using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs.Employee;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace AdvanceUI.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService; 
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public  IActionResult Login()
        {
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Login(EmployeeLoginDTO employeeLoginDTO)
        {
            var dto = await _authService.Login(employeeLoginDTO);
            if (dto == null) 
            { 
                ViewData["Error"] = "Kullanıcı adı veya şifre hatalı!"; 
                return View();
			}

			HttpContext.Response.Cookies.Append("token", dto.Token, new CookieOptions
			{
				Expires = System.DateTimeOffset.Now.AddSeconds(20),
			});

			var claims = new List<Claim>()
			{
				new Claim(ClaimTypes.Name,dto.Name),
				new Claim(ClaimTypes.Surname,dto.Surname),
				new Claim(ClaimTypes.Email,dto.Email),
				new Claim(ClaimTypes.Anonymous,dto.BusinessUnit.BusinessUnitName),
				new Claim(ClaimTypes.Role, dto.Title.TitleName)
			};

			var userIdentity = new ClaimsIdentity(claims, "login");
			var userpri = new ClaimsPrincipal(userIdentity);

			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userpri);

            TempData["EmployeeFullName"] = dto.Name + " " + dto.Surname;
            TempData["EmployeeTitle"] = dto.Title.TitleName;

			return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Register(EmployeeRegisterDTO employeeRegisterDTO)
		{
			var state = await _authService.Register(employeeRegisterDTO);

			if(state)
				return RedirectToAction("Login","Auth");

			return View();
		}
	}
}
