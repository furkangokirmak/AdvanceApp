using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs;
using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.AdvanceHistory;
using AdvanceUI.DTOs.Employee;
using AdvanceUI.DTOs.Payment;
using AdvanceUI.DTOs.Project;
using AdvanceUI.DTOs.Receipt;
using AdvanceUI.UI.Filters;
using AdvanceUI.UI.Models;
using AdvanceUI.Validation.FluentValidation.Advance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdvanceUI.UI.Controllers
{
    [Authorize]
    [TokenAuthorizationFilter]
    public class AdvanceController : Controller
    {
        private readonly GenericService _genericService;
        private readonly IMemoryCache _memoryCache;

        public AdvanceController(GenericService genericService, IMemoryCache memoryCache)
        {
            _genericService = genericService;
            _memoryCache = memoryCache;
        }

        /// <summary>
        /// Yeni Avans Talebi Oluşturma Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AdvanceRequest()
        {
            var myToken = HttpContext.Request.Cookies["token"];
            var projects = await _genericService.GetDatas<List<ProjectSelectDTO>>("Project/GetAll", token: myToken);
            ViewBag.Projects = projects;

            return View();
        }

        /// <summary>
        /// Yeni Avans Talebi Post İsteği
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdvanceRequest(AdvanceInsertDTO advanceInsertDTO)
        {
            var myToken = HttpContext.Request.Cookies["token"];

            if (!ModelState.IsValid)
            {
                var projects = await _genericService.GetDatas<List<ProjectSelectDTO>>("Project/GetAll", token: myToken);
                ViewBag.Projects = projects;
                return View(advanceInsertDTO);
            }

                int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
            advanceInsertDTO.EmployeeId = id;

            var addedAdvance = await _genericService.PostDatas<Result, AdvanceInsertDTO>("Advance/AddAdvance",advanceInsertDTO, token: myToken);

            if (addedAdvance.Succeeded)
                return RedirectToAction("MyAdvanceRequests", "Advance");

            return View();
        }

        /// <summary>
        /// Geçmiş Avans Taleplerim Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyAdvanceRequests()
        {
            var myToken = HttpContext.Request.Cookies["token"];
            int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
 
            var advances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetEmployeeAdvances/{id}", token: myToken);

            return View(advances);
        }

        /// <summary>
        /// Geçmiş Avans Talepleri Detay Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyAdvanceRequestDetails(int id)
        {
            var myToken = HttpContext.Request.Cookies["token"];
            if (!_memoryCache.TryGetValue($"AdvanceData_{id}", out AdvanceSelectDTO advance))
            {
                advance = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{id}", token: myToken);

                var project = await _genericService.GetDatas<ProjectSelectDTO>($"Project/Get/{advance.ProjectId}", token: myToken);
                advance.Project = project;

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30)
                };

                _memoryCache.Set($"AdvanceData_{id}", advance, cacheEntryOptions);
            }

            ViewData["Advance"] = advance;

            var advanceHistories = await _genericService.GetDatas<List<AdvanceHistorySelectDTO>>($"Advance/GetAdvanceHistories/{id}", token: myToken);

            return View(advanceHistories);
        }

        /// <summary>
        /// Onay Bekleyen Talepler Ekranı (Ödeme Tarihi Bekleyen Talepler ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles ="Birim Müdürü, Direktör, Genel Müdür Yardımcısı, Genel Müdür, Finans Müdürü")]
        public async Task<IActionResult> PendingAdvanceRequests()
        {
            var myToken = HttpContext.Request.Cookies["token"];
            int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
            string role = User.Claims.Where(a => a.Type == ClaimTypes.Role).Select(a => a.Value).SingleOrDefault();

            int roleId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.UserData).Select(a => a.Value).SingleOrDefault());


            List<AdvanceSelectDTO> pendingAdvances;

            if (role == "Finans Müdürü")
            {
                pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingPaymentDateAdvance", token: myToken);
            }
            else
            {
                pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingAdvances/{id}", token: myToken);
            }

            return View(pendingAdvances);
        }

        /// <summary>
        /// Onay Bekleyen Talep Detay Ekranı (Ödeme Tarihi Bekleyen Talep Detay Ekranı  ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Birim Müdürü, Direktör, Genel Müdür Yardımcısı, Genel Müdür, Finans Müdürü, Muhasebeci")]
        public async Task<IActionResult> PendingAdvanceRequestDetails(int id)
        {
            var advanceHistories = await GetAdvanceDatas(id);

            return View(advanceHistories);
        }

        private async Task<List<AdvanceHistorySelectDTO>> GetAdvanceDatas(int id)
        {
            var myToken = HttpContext.Request.Cookies["token"];
            var advance = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{id}", token: myToken);
            var project = await _genericService.GetDatas<ProjectSelectDTO>($"Project/Get/{advance.ProjectId}", token: myToken);
            advance.Project = project;
            ViewData["Advance"] = advance;

            var advanceHistories = await _genericService.GetDatas<List<AdvanceHistorySelectDTO>>($"Advance/GetAdvanceHistories/{id}", token: myToken);

            return advanceHistories;
        }

        [HttpPost]
        [Authorize(Roles = "Birim Müdürü, Direktör, Genel Müdür Yardımcısı, Genel Müdür")]
        public async Task<IActionResult> PendingAdvanceRequest(int amount, string state, int advanceId, int statusId, decimal amounts)
        {
            var myToken = HttpContext.Request.Cookies["token"];
            int userId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());

            if(amount > amounts && amount > 0)
            {
                var advanceHistories = await GetAdvanceDatas(advanceId);
                ViewData["AmountError"] = "Maksimum son onaylanan talep tutarı kadar girebilirsiniz.";

                return View("PendingAdvanceRequestDetails", advanceHistories);
            }

            var adHistory = new AdvanceHistorySelectDTO
            {
                AdvanceId = advanceId,
                StatusId = statusId,
                ApprovedAmount = amount,
                TransactorId = userId,
                Date = DateTime.Now,                          
            };

            var advances = await _genericService.PostDatas<Result, AdvanceHistorySelectDTO>($"Advance/AdvanceRequest" + state, adHistory, token: myToken);

            return RedirectToAction("PendingAdvanceRequests","Advance");
        }

        [HttpPost]
        [Authorize(Roles = "Finans Müdürü")]
        public async Task<IActionResult> AdvanceRequestSetDate(DateTime date, int advanceId, decimal amounts)
        {
            var myToken = HttpContext.Request.Cookies["token"];
            int userId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());

            var advances = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{advanceId}", token: myToken);
            if(date < advances.DesiredDate.Value)
            {
                ViewData["AmountError"] = "İstenilen tarihten önce bir tarih seçemezsiniz.";
                var advanceHistories = await GetAdvanceDatas(advanceId);

                return View("PendingAdvanceRequestDetails", advanceHistories);
            }

            var adHistory = new AdvanceHistorySelectDTO
			{
				AdvanceId = advanceId,
				ApprovedAmount = amounts,
				TransactorId = userId,
				Date = date, // belirlenen ödeme tarihi için
			};

			var advance = await _genericService.PostDatas<Result, AdvanceHistorySelectDTO>($"Advance/AdvanceRequestSetPaymentDate", adHistory, token: myToken);

			return RedirectToAction("PendingAdvanceRequests", "Advance");
		}

        /// <summary>
        /// Avans Listeleri Ekranı (Ön muhasebe uzmanı için)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Muhasebeci")]
        public async Task<IActionResult> AdvanceList()
        {
            var myToken = HttpContext.Request.Cookies["token"];
            var pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingReceipt", token: myToken);

            return View(pendingAdvances);
        }

        [HttpPost]
        [Authorize(Roles = "Muhasebeci")]
        public async Task<IActionResult> AdvanceRequestReceipt(string receiptNo, int advanceId, string accountantState, decimal amounts, DateTime paymentDate)
        {
            if (DateTime.Now < paymentDate)
            {
                ViewData["PaymentError"] = "Ödeme yapılacak tarihten önce bir işlem gerçekleştiremezsiniz.";
                var advanceHistories = await GetAdvanceDatas(advanceId);

                return View("PendingAdvanceRequestDetails", advanceHistories);
            }


            var myToken = HttpContext.Request.Cookies["token"];
            int userId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());

            bool state = false;
            int statusId = 207;
            if (accountantState == "Geri Ödeme")
            {
                state = true;
                statusId = 208;
            }
                                        
            var advance = new AdvanceSelectDTO
            {
                Receipts = new List<ReceiptSelectDTO> {
                    new ReceiptSelectDTO {
                        AccountantId = userId,
                        AdvanceId = advanceId,
                        Date = DateTime.Now,
                        ReceiptNo = receiptNo,
                        IsRefundReceipt = state }
                },

                AdvanceHistories = new List<AdvanceHistorySelectDTO>
                {
                    new AdvanceHistorySelectDTO
                    {
                        AdvanceId = advanceId,
                        TransactorId = userId,
                        Date = DateTime.Now,
                        ApprovedAmount = amounts,    
                        StatusId = statusId
                    }
                }
                
            };

            var result = await _genericService.PostDatas<Result, AdvanceSelectDTO>($"Advance/AdvanceRequestReceipt", advance, token: myToken);

            return RedirectToAction("AdvanceList", "Advance");
        }

        /// <summary>
        /// Yetkili yöneticiler için rapor alma ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Birim Müdürü, Direktör, Genel Müdür Yardımcısı, Genel Müdür, Finans Müdürü, Muhasebeci")]
        public async Task<IActionResult> AdvanceReport()
        {
            int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
            var myToken = HttpContext.Request.Cookies["token"];
            var advanceList = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetAdvanceList/{id}", token: myToken);

            return View(advanceList);
        }

    }
}
