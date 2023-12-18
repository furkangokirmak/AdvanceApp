#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "805fee4b464aa47c886a2dbd629c6b59049cee22418b63df649bb699919b1ebe"
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
#nullable restore
#line 4 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.Title;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.BusinessUnit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.Advance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.AdvanceHistory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\_ViewImports.cshtml"
using AdvanceUI.DTOs.Page;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"805fee4b464aa47c886a2dbd629c6b59049cee22418b63df649bb699919b1ebe", @"/Views/Advance/AdvanceList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6fbe7050065225e7dd421baa0a72d039bba0fadee7a95901eaaeff85c81e4e75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_AdvanceList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvanceSelectDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PendingAdvanceRequestDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
  
    ViewData["Title"] = "Avans Talep Listesi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container col-md-12"">
    <div class=""card"">
        <div class=""card-body table-border-style"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Çalışanın Adı</th>
                            <th>Ünvanı</th>
                            <th>Birimi</th>
                            <th>Talep<br />Tutarı</th>
                            <th>Talep<br />Oluşturma<br />Tarihi</th>
                            <th>İstenilen Tarih</th>
                            <th>Proje</th>
                            <th>Talep Durumu</th>
                            <th>Onaylayan<br/>Reddeden</th>
                            <th>Onay/Red<br/>Ünvan</th>
                            <th>Onay/Red<br />Tarihi</th>
                            <th>Onaylanan<br />Tutar</th>
                            <th>Belirlenen<br />Ödeme<br />Tarihi</th>
                            <th");
            WriteLiteral(">Ödeme<br />Yapılan<br />Tarih</th>\r\n                            <th>Geri Ödeme Durumu</th>\r\n                            <th>Detay</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                                   Write(item.Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.Employee.Title.TitleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.Employee.BusinessUnit.BusinessUnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(Math.Round(item.AdvanceAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.RequestDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.DesiredDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 41 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>Onaylanmış</td>                                                               \r\n                                <td>");
#nullable restore
#line 43 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Transactor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                                                                      Write(item.AdvanceHistories.LastOrDefault().Transactor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Transactor.Title.TitleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                               Write(Math.Round(@item.AdvanceHistories.LastOrDefault().ApprovedAmount.Value,0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n\r\n                                <td>\r\n");
#nullable restore
#line 49 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                     if (item.Payments != null && item.Payments.Any())
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                   Write(item.Payments.FirstOrDefault().DeterminedPaymentDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                                                                                                          
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n                                <td>\r\n");
#nullable restore
#line 56 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                     if (item.Receipts != null && item.Receipts.Any(x => x.IsRefundReceipt == false))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                   Write(item.Receipts.FirstOrDefault(x => x.IsRefundReceipt == false).Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                                                                                                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n");
#nullable restore
#line 62 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                 if (item.Receipts != null && item.Receipts.Any(x => x.IsRefundReceipt == true))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Geri Ödeme Yapıldı</td>\r\n");
#nullable restore
#line 65 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Geri Ödeme Yapılmadı</td>\r\n");
#nullable restore
#line 69 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805fee4b464aa47c886a2dbd629c6b59049cee22418b63df649bb699919b1ebe15378", async() => {
                WriteLiteral("<i class=\"icon feather icon-edit f-16 text-success\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvanceSelectDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
