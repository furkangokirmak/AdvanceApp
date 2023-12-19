using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs.Employee;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AdvanceUI.DTOs.Title;
using AdvanceUI.DTOs.BusinessUnit;
using System;
using AdvanceUI.DTOs;
using AdvanceUI.UI.Extensions;


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
				Expires = DateTimeOffset.Now.AddMinutes(20),
			});

			var claims = new List<Claim>()
			{
				new Claim(ClaimTypes.NameIdentifier,dto.Id.ToString()),
				new Claim(ClaimTypes.Name,dto.Name),
				new Claim(ClaimTypes.Surname,dto.Surname),
				new Claim(ClaimTypes.Email,dto.Email),
				new Claim(ClaimTypes.Anonymous,dto.BusinessUnit.BusinessUnitName),
				new Claim(ClaimTypes.Role, dto.Title.TitleName),
				new Claim(ClaimTypes.UserData, dto.Title.Id.ToString()),
				new Claim(ClaimTypes.MobilePhone, dto.PhoneNumber)
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
			await GetRegisterDatas();

            return View();
        }

		[HttpPost]
		public async Task<IActionResult> Register(EmployeeRegisterDTO employeeRegisterDTO)
		{
            if (!ModelState.IsValid)
            {
                await GetRegisterDatas();
                return View(employeeRegisterDTO);
            }

            var state = await _authService.Register(employeeRegisterDTO);

            if (!state.Succeeded)
            {
                ViewData["RegisterError"] = state.Message;
                await GetRegisterDatas();

                return View();
            }
				         
            return RedirectToAction("Login", "Auth");
        }

		private async Task GetRegisterDatas()
		{
            var employees = await _genericService.GetDatas<List<EmployeeSelectDTO>>("Employee/GetAll");
            var titles = await _genericService.GetDatas<List<TitleSelectDTO>>("Title/GetAll");
            var businessUnits = await _genericService.GetDatas<List<BusinessUnitSelectDTO>>("BusinessUnit/GetAll");

            ViewBag.Employees = employees;
            ViewBag.Titles = titles;
            ViewBag.BusinessUnits = businessUnits;
        }

		[HttpGet]
		public IActionResult ForgotPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ForgotPassword(string email)
		{
			var employee = await _genericService.GetDatas<EmployeeSelectDTO>($"Employee/GetEmployee/{email}");

			if (employee != null)
			{
				var result = await _genericService.PostDatas<Result, EmployeeSelectDTO>($"Auth/ForgotPassword", employee);
            }

			ViewData["ForgotPasswordMsg"] = "E-posta sistemimizde mevcutsa, bir şifre sıfırlama e-postası alacaksınız.";

			return View();
		}

		[HttpGet]
		public async Task<ActionResult> ResetPassword(string token)
		{
			var result = await _genericService.GetDatas<EmployeeSelectDTO>($"Auth/ResetPassword/{token}");

			if (result!=null)
			{             
                HttpContext.Session.SetObject("user",result);
				return View();
			}

			return RedirectToAction("Login", "Auth");
		}

        [HttpPost]
        public async Task<ActionResult> SetPassword(string password)
        {
            var employee = HttpContext.Session.GetObject<EmployeeSelectDTO>("user");

            var newEmp = new EmployeeLoginDTO { Email = employee.Email, Password = password };

            var result = await _genericService.PostDatas<EmployeeLoginDTO, EmployeeLoginDTO>($"Auth/SetPassword",newEmp);

            return RedirectToAction("Login", "Auth");
        }
    }
}
