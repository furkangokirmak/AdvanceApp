﻿using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs;
using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.AdvanceHistory;
using AdvanceUI.DTOs.Employee;
using AdvanceUI.DTOs.Payment;
using AdvanceUI.DTOs.Project;
using AdvanceUI.DTOs.Receipt;
using AdvanceUI.UI.Models;
using AdvanceUI.Validation.FluentValidation.Advance;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AdvanceUI.UI.Controllers
{
    [Authorize]
    public class AdvanceController : Controller
    {
        private readonly GenericService _genericService;
        private readonly IMemoryCache _memoryCache;

        public AdvanceController(GenericService genericService, IMemoryCache memoryCache)
        {
            _genericService = genericService;
        }

        /// <summary>
        /// Yeni Avans Talebi Oluşturma Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AdvanceRequest()
        {
            var projects = await _genericService.GetDatas<List<ProjectSelectDTO>>("Project/GetAll");
            ViewBag.Projects = projects;

            return View();
        }

        /// <summary>
        /// Yeni Avans Talebi Post İsteği
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AdvanceRequest(AdvanceInsertDTO advanceInsertDTO)
        {
            if (!ModelState.IsValid)
            {
                var projects = await _genericService.GetDatas<List<ProjectSelectDTO>>("Project/GetAll");
                ViewBag.Projects = projects;
                return View(advanceInsertDTO);
            }

                int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
            advanceInsertDTO.EmployeeId = id;

            //var validator = new AdvanceInsertDTOValidator();
            //var validationResult = validator.Validate(advanceInsertDTO);

            var addedAdvance = await _genericService.PostDatas<Result, AdvanceInsertDTO>("Advance/AddAdvance",advanceInsertDTO);

            if (addedAdvance.Succeeded)
                return RedirectToAction("MyAdvanceRequests", "Advance");

            return View();
        }

        /// <summary>
        /// Geçmiş Avans Taleplerim Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> MyAdvanceRequests()
        {
            int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
 
            var advances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetEmployeeAdvances/{id}");

            var Tasks = advances.Select(async x => 
            {
                var status = await _genericService.GetDatas<StatusSelectDTO>($"Status/Get/{x.StatusId}");
                x.Status.StatusName = status.StatusName;

                var project = await _genericService.GetDatas<ProjectSelectDTO>($"Project/Get/{x.ProjectId}");
                x.Project.ProjectName = project.ProjectName;
            });


            await Task.WhenAll(Tasks);

            return View(advances);
        }

        /// <summary>
        /// Geçmiş Avans Talepleri Detay Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> MyAdvanceRequestDetails(int id)
        {
            if (!_memoryCache.TryGetValue($"AdvanceData_{id}", out AdvanceSelectDTO myadvance))
            {
                var advance = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{id}");
                var project = await _genericService.GetDatas<ProjectSelectDTO>($"Project/Get/{advance.ProjectId}");
                advance.Project = project;
                ViewData["Advance"] = advance;
            }

            var advanceHistories = await _genericService.GetDatas<List<AdvanceHistorySelectDTO>>($"Advance/GetAdvanceHistories/{id}");

            return View(advanceHistories);
        }

        /// <summary>
        /// Onay Bekleyen Talepler Ekranı (Ödeme Tarihi Bekleyen Talepler ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PendingAdvanceRequests()
        {
            int id = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());
            string role = User.Claims.Where(a => a.Type == ClaimTypes.Role).Select(a => a.Value).SingleOrDefault();

            int roleId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.UserData).Select(a => a.Value).SingleOrDefault());


            List<AdvanceSelectDTO> pendingAdvances;

            if (role == "Finans Müdürü")
            {
                pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingPaymentDateAdvance");
            }
            else
            {
                pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingAdvances/{id}");
            }

            return View(pendingAdvances);
        }

        /// <summary>
        /// Onay Bekleyen Talep Detay Ekranı (Ödeme Tarihi Bekleyen Talep Detay Ekranı  ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> PendingAdvanceRequestDetails(int id)
        {
            var advanceHistories = await GetAdvanceDatas(id);

            return View(advanceHistories);
        }

        private async Task<List<AdvanceHistorySelectDTO>> GetAdvanceDatas(int id)
        {
            var advance = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{id}");
            var project = await _genericService.GetDatas<ProjectSelectDTO>($"Project/Get/{advance.ProjectId}");
            advance.Project = project;
            ViewData["Advance"] = advance;

            var advanceHistories = await _genericService.GetDatas<List<AdvanceHistorySelectDTO>>($"Advance/GetAdvanceHistories/{id}");

            return advanceHistories;
        }

        [HttpPost]
        public async Task<IActionResult> PendingAdvanceRequest(int amount, string state, int advanceId, int statusId, decimal amounts)
        {
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

            var advances = await _genericService.PostDatas<Result, AdvanceHistorySelectDTO>($"Advance/AdvanceRequest" + state, adHistory);

            return RedirectToAction("PendingAdvanceRequests","Advance");
        }

        [HttpPost]
        public async Task<IActionResult> AdvanceRequestSetDate(DateTime date, int advanceId, decimal amounts)
        {
			int userId = Convert.ToInt32(User.Claims.Where(a => a.Type == ClaimTypes.NameIdentifier).Select(a => a.Value).SingleOrDefault());

            var advances = await _genericService.GetDatas<AdvanceSelectDTO>($"Advance/GetAdvance/{advanceId}");
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

			var advance = await _genericService.PostDatas<Result, AdvanceHistorySelectDTO>($"Advance/AdvanceRequestSetPaymentDate", adHistory);

			return RedirectToAction("PendingAdvanceRequests", "Advance");
		}

        /// <summary>
        /// Avans Listeleri Ekranı (Ön muhasebe uzmanı için)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AdvanceList()
        {
            var pendingAdvances = await _genericService.GetDatas<List<AdvanceSelectDTO>>($"Advance/GetPendingReceipt");

            return View(pendingAdvances);
        }

        [HttpPost]
        public async Task<IActionResult> AdvanceRequestReceipt(string receiptNo, int advanceId, string accountantState, decimal amounts)
        {          
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

            var result = await _genericService.PostDatas<Result, AdvanceSelectDTO>($"Advance/AdvanceRequestReceipt", advance);

            return RedirectToAction("AdvanceList", "Advance");
        }

        /// <summary>
        /// Yetkili yöneticiler için rapor alma ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AdvanceReport()
        {
            return View();
        }

    }
}
