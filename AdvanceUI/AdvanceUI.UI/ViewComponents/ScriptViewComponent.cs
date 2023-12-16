using Microsoft.AspNetCore.Mvc;

namespace AdvanceUI.UI.ViewComponents
{
    public class ScriptViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {


            return View();
        }
    }
}
