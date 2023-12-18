using AdvanceUI.ConnectApi;
using AdvanceUI.DTOs.Advance;
using AdvanceUI.DTOs.Page;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceUI.UI.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {

        private readonly GenericService _genericService;
        private readonly IMemoryCache _memoryCache;

        public SidebarViewComponent(GenericService genericService, IMemoryCache memoryCache)
        {
            _genericService = genericService;
            _memoryCache = memoryCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var myToken = HttpContext.Request.Cookies["token"];
            if (!_memoryCache.TryGetValue($"PageData_{id}", out List<PageSelectDTO> pages))
            {
                pages = await _genericService.GetDatas<List<PageSelectDTO>>($"Page/GetPagesWithSelectAuthorization/{id}", token: myToken);

                var cacheEntryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(5)
                };

                _memoryCache.Set($"PageData_{id}", pages, cacheEntryOptions);
            }

            return View(pages);
        }
    }
}