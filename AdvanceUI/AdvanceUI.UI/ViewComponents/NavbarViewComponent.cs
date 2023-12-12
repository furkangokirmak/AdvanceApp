using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
