#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "768df8c439b79d5158168bb93cde7eba704eff68fcbbc085db28c676c84ed764"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_AdvanceList), @"mvc.1.0.view", @"/Views/Advance/AdvanceList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"768df8c439b79d5158168bb93cde7eba704eff68fcbbc085db28c676c84ed764", @"/Views/Advance/AdvanceList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"77ddf401712c6a49857b30baca85701974cb1bb3b80561192b573127621bdfeb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_AdvanceList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
  
    ViewData["Title"] = "AdvanceList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container col-md-12"">
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""mt-1"">Avans Talep Listesi</h3>
        </div>
        <div class=""card-body table-border-style"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Çalışanın<br />Adı</th>
                            <th>Ünvanı</th>
                            <th>Birimi</th>
                            <th>Talep<br />Tutarı</th>
                            <th>Talep<br />Oluşturma<br />Tarihi</th>
                            <th>İstenilen<br />Tarih</th>
                            <th>Proje</th>
                            <th>Talep<br />Durumu</th>
                            <th>Onaylayan<br />Reddeden</th>
                            <th>Ünvan</th>
                            <th>Tarih</th>
                            <th>Onaylanan<br />Tutar</th>
         ");
            WriteLiteral(@"                   <th>Belirlenen<br />Ödeme<br />Tarihi</th>
                            <th>Ödeme<br />Yapılan<br />Tarih</th>
                            <th>Geri<br />Ödeme<br />Durumu</th>
                            <th>Detay</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>100</td>
                            <td>1.1.2022</td>
                            <td>15.1.2022</td>
                            <td>1000 TL</td>
                            <td>Onaylanmış</td>
                            <td>Özcan Deniz</td>
                            <td>Satıcı</td>
                            <td>14.1.2022</td>
                            <td>Son</td>
                            <td>Son</td>
                            <td>Son</td>
                            <td>Son</td>
                            <td>Son</td>
                            <td>Son</td>
                            <td>Son<");
            WriteLiteral("/td>\r\n                            <td>Tıkla</td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
