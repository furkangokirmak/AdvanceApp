using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
