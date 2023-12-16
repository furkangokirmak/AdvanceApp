#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1ca3dc6b33acfb8f734f12d963600600bf021c29e7776fef407d51e4e6e90328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_MyAdvanceRequestDetails), @"mvc.1.0.view", @"/Views/Advance/MyAdvanceRequestDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"1ca3dc6b33acfb8f734f12d963600600bf021c29e7776fef407d51e4e6e90328", @"/Views/Advance/MyAdvanceRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6fbe7050065225e7dd421baa0a72d039bba0fadee7a95901eaaeff85c81e4e75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_MyAdvanceRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvanceHistorySelectDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
  
    ViewData["Title"] = "Avans Talebi Tarihçesi";
    var advance = ViewData["Advance"] as AdvanceSelectDTO;
    string geriOdeme = "";
    int row = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container col-md-12"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <p class=""card-text""><strong>Talep No:</strong> ");
#nullable restore
#line 16 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                       Write(advance.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Talep Oluşturma Tarihi:</strong> ");
#nullable restore
#line 17 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                                     Write(advance.RequestDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Alınmak İstenen Tarih:</strong> ");
#nullable restore
#line 18 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                                    Write(advance.DesiredDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Proje:</strong> ");
#nullable restore
#line 19 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                    Write(advance.Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Açıklama:</strong> ");
#nullable restore
#line 20 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                       Write(advance.AdvanceDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <p class=""card-text""><strong>Talep Edilen Tutar:</strong> ");
#nullable restore
#line 27 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                                 Write(Math.Round(advance.AdvanceAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                            <p class=\"card-text\"><strong>Onaylanan Tutar:</strong> ");
#nullable restore
#line 28 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                              Write(Math.Round(Model.LastOrDefault().ApprovedAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                            <p class=\"card-text\"><strong>Son Durumu:</strong> ");
#nullable restore
#line 29 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                         Write(Model.LastOrDefault().Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Makbuz No:</strong> \r\n");
#nullable restore
#line 31 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                 if (advance.Receipts != null && advance.Receipts.Any(x => x.IsRefundReceipt == false))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                               Write(advance.Receipts.FirstOrDefault(x => x.IsRefundReceipt == false).ReceiptNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                                                               ;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            <p class=\"card-text\"><strong>Avans Geri Ödeme Durumu:</strong> \r\n");
#nullable restore
#line 37 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                 if (advance.Receipts != null && advance.Receipts.Any(x => x.IsRefundReceipt == true))
                                {
                                    geriOdeme = "Geri Ödeme Yapıldı";
                                }
                                else
                                {
                                    geriOdeme = "Geri Ödeme Yapılmadı";
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 45 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                           Write(geriOdeme);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">İşlem No</th>
                                <th scope=""col"">Durum</th>
                                <th scope=""col"">İşlem Zamanı</th>
                                <th scope=""col"">İşlemi Yapan</th>
                                <th scope=""col"">Sonraki Aşama Kullanıcısı</th>
                                <th scope=""col"">Sonraki Durum</th>
                                <th scope=""col"">Onaylanan Tutar</th>
                                <th scope=""col"">Ödeme Yapılacak Tarih</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 65 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                             foreach (var item in Model)
                            {
                                row = row +1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 69 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                               Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 70 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(item.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 71 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 72 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 72 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                         Write(item.Transactor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 73 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.UpperEmployee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                       Write(item.Transactor.UpperEmployee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 74 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.UpperEmployee.Title.TitleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Onayına</td>\r\n                                    <td>");
#nullable restore
#line 75 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                   Write(Math.Round(item.ApprovedAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                    <td>\r\n");
#nullable restore
#line 77 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                         if (advance.Payments != null && advance.Payments.Any() && advance.Payments.FirstOrDefault().FinanceManagerId == @item.TransactorId)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                       Write(advance.Payments.FirstOrDefault().DeterminedPaymentDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                                                                                                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>                               \r\n");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\MyAdvanceRequestDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AdvanceHistorySelectDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
