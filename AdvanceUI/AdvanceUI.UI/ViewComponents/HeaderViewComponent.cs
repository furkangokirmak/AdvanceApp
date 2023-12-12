using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
