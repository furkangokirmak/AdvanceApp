#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a420b92931e6235a90d76f635c25b66f047bfa084766e8667dc208be3c46ad41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_PendingAdvanceRequestDetails), @"mvc.1.0.view", @"/Views/Advance/PendingAdvanceRequestDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a420b92931e6235a90d76f635c25b66f047bfa084766e8667dc208be3c46ad41", @"/Views/Advance/PendingAdvanceRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3f3f99b1198db16352138b99a67efc652c40b08cdc30b6c73450566332ed2c4a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_PendingAdvanceRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvanceHistorySelectDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PendingAdvanceRequestAccept", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Advance/PendingAdvanceRequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
  
    ViewData["Title"] = "Avans Talebi Tarihçesi";
    var advance = ViewData["Advance"] as AdvanceSelectDTO;
    string geriOdeme = "";
    int row = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .custom-card {
        width: 40%;
        margin: auto;
    }
</style>

<div class=""container col-md-12"">
    <div class=""card"">

        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <p class=""card-text""><strong>Talep No:</strong> ");
#nullable restore
#line 24 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                       Write(advance.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Talep Oluşturma Tarihi:</strong> ");
#nullable restore
#line 25 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                                     Write(advance.RequestDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Alınmak İstenen Tarih:</strong> ");
#nullable restore
#line 26 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                                    Write(advance.DesiredDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Proje:</strong> ");
#nullable restore
#line 27 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                    Write(advance.Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><strong>Açıklama:</strong> ");
#nullable restore
#line 28 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
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
#line 35 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                                 Write(Math.Round(advance.AdvanceAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                            <p class=\"card-text\"><strong>Onaylanan Tutar:</strong> ");
#nullable restore
#line 36 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                              Write(Math.Round(Model.LastOrDefault().ApprovedAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</p>\r\n                            <p class=\"card-text\"><strong>Son Durumu:</strong> ");
#nullable restore
#line 37 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                         Write(Model.LastOrDefault().Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\">\r\n                                <strong>Makbuz No:</strong>\r\n");
#nullable restore
#line 40 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                 if (advance.Receipts != null && advance.Receipts.Any(x => x.IsRefundReceipt == false))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                               Write(advance.Receipts.FirstOrDefault(x => x.IsRefundReceipt == false).ReceiptNo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                                                                                                   
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                            <p class=\"card-text\">\r\n                                <strong>Avans Geri Ödeme Durumu:</strong>\r\n");
#nullable restore
#line 47 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
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
#line 55 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
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
#line 76 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                             foreach (var item in Model)
                            {
                                row = row + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 80 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                               Write(row);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 81 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(item.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 82 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                         Write(item.Transactor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 84 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.UpperEmployee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 84 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                       Write(item.Transactor.UpperEmployee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 85 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(item.Transactor.UpperEmployee.Title.TitleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Onayına</td>\r\n                                    <td>");
#nullable restore
#line 86 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                   Write(Math.Round(item.ApprovedAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                    <td>\r\n");
#nullable restore
#line 88 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                         if (advance.Payments != null && advance.Payments.Any() && advance.Payments.FirstOrDefault().FinanceManagerId == @item.TransactorId)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                       Write(advance.Payments.FirstOrDefault().DeterminedPaymentDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                                                                                                                                 
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 94 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n");
#nullable restore
#line 99 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                 if (User.IsInRole("Finans Müdürü"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card custom-card\">\r\n                        <div class=\"card-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a420b92931e6235a90d76f635c25b66f047bfa084766e8667dc208be3c46ad4120046", async() => {
                WriteLiteral(@"
                                <h5 class=""card-title"">Uygun Görülen Ödeme Tarihi:</h5>
                                <div class=""input-group date mb-1"" id=""datetimepicker"" data-target-input=""nearest"">
                                    <input type=""date"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker"" />
                                </div>
                                <div class=""d-flex justify-content-between"">
                                    <button type=""button"" class=""btn btn-secondary"">Formu Temizle</button>
                                    <button type=""button"" class=""btn btn-primary"">Kaydet</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 116 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                }
                else if (User.IsInRole("Muhasebe Uzmanı"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""card custom-card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Avans Teslimi Makbuz No:</h5>
                            <div class=""input-group mb-1"">
                                <input type=""text"" class=""form-control"" placeholder=""Makbuz No"" aria-label=""Tutar"" aria-describedby=""basic-addon2"">
                            </div>
                            <div class=""d-flex justify-content-between"">
                                <button type=""button"" class=""btn btn-secondary"">Çıkış</button>
                                <button type=""button"" class=""btn btn-primary"">Kaydet</button>
                            </div>
                        </div>
                    </div>
");
            WriteLiteral(@"                    <div class=""card custom-card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Geri Ödeme Makbuz No:</h5>
                            <div class=""input-group mb-1"">
                                <input type=""text"" class=""form-control"" placeholder=""Makbuz No"" aria-label=""Tutar"" aria-describedby=""basic-addon2"">
                            </div>
                            <div class=""d-flex justify-content-between"">
                                <button type=""button"" class=""btn btn-secondary"">Çıkış</button>
                                <button type=""button"" class=""btn btn-primary"">Kaydet</button>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 144 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card custom-card\">\r\n                        <div class=\"card-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a420b92931e6235a90d76f635c25b66f047bfa084766e8667dc208be3c46ad4125152", async() => {
                WriteLiteral(@"
                            <h5 class=""card-title"">Uygun Görülen Tutar:</h5>
                            <div class=""input-group mb-1"">
                                    <input type=""text"" class=""form-control"" id=""amount"" name=""amount"" placeholder=""Tutar"" aria-label=""Tutar"" aria-describedby=""basic-addon2"">
                                <div class=""input-group-append"">
                                    <span class=""input-group-text"" id=""basic-addon2"">TL</span>
                                </div>
                            </div>
                                <input type=""hidden"" id=""advanceId"" name=""advanceId""");
                BeginWriteAttribute("value", " value=\"", 8892, "\"", 8911, 1);
#nullable restore
#line 157 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
WriteAttributeValue("", 8900, advance.Id, 8900, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                                <input type=\"hidden\" id=\"statusId\" name=\"statusId\"");
                BeginWriteAttribute("value", " value=\"", 9006, "\"", 9046, 1);
#nullable restore
#line 158 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
WriteAttributeValue("", 9014, Model.LastOrDefault().Status.Id, 9014, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required>
                            <div class=""d-flex justify-content-between"">
                                    <button type=""submit"" name=""state"" value=""Reject"" class=""btn btn-secondary"">Reddet</button>
                                    <button type=""submit"" name=""state"" value=""Accept"" class=""btn btn-primary"">Onayla</button>
                            </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 166 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
