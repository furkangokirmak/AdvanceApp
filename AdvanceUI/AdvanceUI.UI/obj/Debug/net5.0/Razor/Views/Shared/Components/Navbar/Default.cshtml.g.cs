#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Shared\Components\Navbar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4b9b812de13c53638aed5af16620bc675f8300bbd0d9744417f53a0c0a657e0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navbar/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Shared\Components\Navbar\Default.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4b9b812de13c53638aed5af16620bc675f8300bbd0d9744417f53a0c0a657e0d", @"/Views/Shared/Components/Navbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"77ddf401712c6a49857b30baca85701974cb1bb3b80561192b573127621bdfeb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Navbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dashboardkit/dist/assets/images/user/avatar-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-avtar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<header class=""pc-header "">
	<div class=""header-wrapper"">
		<div class=""ml-auto"">
			<ul class=""list-unstyled"">
				<li class=""dropdown pc-h-item"">
					<a class=""pc-head-link dropdown-toggle arrow-none mr-0"" data-toggle=""dropdown"" href=""#"" role=""button"" aria-haspopup=""false"" aria-expanded=""false"">
						<i class=""material-icons-two-tone"">search</i>
					</a>
					<div class=""dropdown-menu dropdown-menu-right pc-h-dropdown drp-search"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b9b812de13c53638aed5af16620bc675f8300bbd0d9744417f53a0c0a657e0d6055", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"form-group mb-0 d-flex align-items-center\">\r\n\t\t\t\t\t\t\t\t<i data-feather=\"search\"></i>\r\n\t\t\t\t\t\t\t\t<input type=\"search\" class=\"form-control border-0 shadow-none\" placeholder=\"Ara. . .\">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</li>\r\n\t\t\t\t<li class=\"dropdown pc-h-item\">\r\n\t\t\t\t\t<a class=\"pc-head-link dropdown-toggle arrow-none mr-0\" data-toggle=\"dropdown\" href=\"#\" role=\"button\" aria-haspopup=\"false\" aria-expanded=\"false\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4b9b812de13c53638aed5af16620bc675f8300bbd0d9744417f53a0c0a657e0d7933", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t<span>\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t<span class=\"user-desc\">");
#nullable restore
#line 24 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Shared\Components\Navbar\Default.cshtml"
                          Write(TempData["EmployeeFullName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
						</span>
					</a>
					<div class=""dropdown-menu dropdown-menu-right pc-h-dropdown"">
						<a href=""auth-signin.html"" class=""dropdown-item"">
							<i class=""material-icons-two-tone"">chrome_reader_mode</i>
							<span>Hesap Ayarları</span>
						</a>

						<a href=""auth-signin.html"" class=""dropdown-item"">
							<i class=""material-icons-two-tone"">chrome_reader_mode</i>
							<span>Çıkış Yap</span>
						</a>
					</div>
				</li>
			</ul>
		</div>

	</div>
</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
