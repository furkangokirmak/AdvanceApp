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
using Microsoft.AspNetCore.Mvc.Rendering;
using AdvanceUI.DTOs.Title;
using AdvanceUI.DTOs.BusinessUnit;
using System;

namespace AdvanceUI.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService; 
        private readonly GenericService _genericService; 

        public AuthController(AuthService authService,GenericService genericService)
        {
            _authService = authService;
            _genericService = genericService;
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
				new Claim(ClaimTypes.NameIdentifier,dto.Id.ToString()),
				new Claim(ClaimTypes.Name,dto.Name),
				new Claim(ClaimTypes.Surname,dto.Surname),
				new Claim(ClaimTypes.Email,dto.Email),
				new Claim(ClaimTypes.Anonymous,dto.BusinessUnit.BusinessUnitName),
				new Claim(ClaimTypes.Role, dto.Title.TitleName)
			};

			var userIdentity = new ClaimsIdentity(claims, "login");
			var userpri = new ClaimsPrincipal(userIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userpri, new AuthenticationProperties()
            {
                ExpiresUtc = DateTimeOffset.Now.AddHours(12)
            });
          
			return RedirectToAction("Index","Home");
        }

		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync();
			return RedirectToAction("Login", "Auth");
		}

		[HttpGet]
        public async Task<IActionResult> Register()
        {
            var employees = await _genericService.GetDatas<List<EmployeeSelectDTO>>("Employee/GetAll");
            var titles = await _genericService.GetDatas<List<TitleSelectDTO>>("Title/GetAll");
            var businessUnits = await _genericService.GetDatas<List<BusinessUnitSelectDTO>>("BusinessUnit/GetAll");

            ViewBag.Employees = employees;
            ViewBag.Titles = titles;
            ViewBag.BusinessUnits = businessUnits;

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
