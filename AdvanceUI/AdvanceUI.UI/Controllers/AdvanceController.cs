using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.Controllers
{
    public class AdvanceController : Controller
    {
        /// <summary>
        /// Yeni Avans Talebi Oluşturma Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AdvanceRequest()
        {
            return View();
        }

        /// <summary>
        /// Geçmiş Avans Taleplerim Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MyAdvanceRequests()
        {
            return View();
        }

        /// <summary>
        /// Geçmiş Avans Talepleri Detay Ekranı
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MyAdvanceRequestDetails()
        {
            return View();
        }

        /// <summary>
        /// Onay Bekleyen Talepler Ekranı (Ödeme Tarihi Bekleyen Talepler ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PendingAdvanceRequests()
        {
            return View();
        }

        /// <summary>
        /// Onay Bekleyen Talep Detay Ekranı (Ödeme Tarihi Bekleyen Talep Detay Ekranı  ile birlikte)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult PendingAdvanceRequestDetails()
        {
            return View();
        }

        /// <summary>
        /// Avans Listeleri Ekranı (Ön muhasebe uzmanı için)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AdvanceList()
        {
            return View();
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
