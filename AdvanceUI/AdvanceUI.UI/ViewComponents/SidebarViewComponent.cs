using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}