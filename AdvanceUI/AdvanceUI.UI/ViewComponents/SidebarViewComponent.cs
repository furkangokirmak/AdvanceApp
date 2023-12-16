using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.Page;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceUI.UI.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {

        private readonly GenericService _genericService;

        public SidebarViewComponent(GenericService genericService)
        {
            _genericService = genericService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var pages = await _genericService.GetDatas<List<PageSelectDTO>>($"Page/GetPagesWithSelectAuthorization/{id}");

            return View(pages);
        }
    }
}