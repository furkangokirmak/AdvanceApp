#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6a6e9207b930fc21c1e45535fa8d6d412637efcf0f7f35d4935551672b75a9f8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6a6e9207b930fc21c1e45535fa8d6d412637efcf0f7f35d4935551672b75a9f8", @"/Views/Advance/PendingAdvanceRequestDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6a381669117ae7d4ce3545a1ca339073f9f40c55869523e734a457e19ab0f60", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_PendingAdvanceRequestDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\PendingAdvanceRequestDetails.cshtml"
  
    ViewData["Title"] = "PendingAdvanceRequestDetails";

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
        <div class=""card-header"">
            <h3 class=""mt-1"">Avans Talebi Tarihçesi</h3>
        </div>

        <div class=""card-body"">
            <div class=""row"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <p class=""card-text""><strong>Talep No:</strong> 5</p>
                                <p class=""card-text""><strong>Talep Oluşturma Tarihi:</strong> 2.10.2020 10:30:52</p>
                                <p class=""card-text""><strong>Alınmak İstenen Tarih:</strong> 21.10.2020</p>
                                <p class=""card-text""><strong>Projeler:</strong> A Projesi, B Projesi</p>
                                <p class=""card-text""><strong>Açıklama:</strong> A ve B Projeleri içi");
            WriteLiteral(@"n izmir eğitimi</p>
                            </div>
                            <div class=""col-md-6"">
                                <p class=""card-text""><strong>Talep No:</strong> 5</p>
                                <p class=""card-text""><strong>Talep Oluşturma Tarihi:</strong> 2.10.2020 10:30:52</p>
                                <p class=""card-text""><strong>Alınmak İstenen Tarih:</strong> 21.10.2020</p>
                                <p class=""card-text""><strong>Projeler:</strong> A Projesi, B Projesi</p>
                                <p class=""card-text""><strong>Açıklama:</strong> A ve B Projeleri için izmir eğitimi</p>
                            </div>
                        </div>

                    </div>
                </div>

                <div class=""col-md-12 table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">İşlem No</th>
       ");
            WriteLiteral(@"                         <th scope=""col"">Durum</th>
                                <th scope=""col"">İşlem Zamanı</th>
                                <th scope=""col"">İşlemi Yapan</th>
                                <th scope=""col"">Sonraki Aşama Kullanıcısı</th>
                                <th scope=""col"">Sonraki Durum</th>
                                <th scope=""col"">Onaylanan Tutar</th>
                                <th scope=""col"">Ödeme Yapılacak Tarih</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope=""row"">1</th>
                                <td>Talep oluşturuldu</td>
                                <td>2.10.2020 10:30:20</td>
                                <td>Gizem Akgün</td>
                                <td>Nejdet Akgün</td>
                                <td>BM Onayı</td>
                                <td> </td>
                          ");
            WriteLiteral(@"      <td> </td>
                            </tr>
                            <tr>
                                <th scope=""row"">2</th>
                                <td>BM onayladı</td>
                                <td>2.10.2020 10:30:20</td>
                                <td>Nejdet</td>
                                <td>Mehmet</td>
                                <td>Direktör Onayına</td>
                                <td>15.000 TL</td>
                                <td> </td>
                            </tr>

                        </tbody>
                    </table>
                </div>

                <div class=""card custom-card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Uygun Görülen Tutar:</h5>
                        <div class=""input-group mb-1"">
                            <input type=""text"" class=""form-control"" placeholder=""Tutar"" aria-label=""Tutar"" aria-describedby=""basic-addon2"">
                      ");
            WriteLiteral(@"      <div class=""input-group-append"">
                                <span class=""input-group-text"" id=""basic-addon2"">TL</span>
                            </div>
                        </div>
                        <div class=""d-flex justify-content-between"">
                            <button type=""button"" class=""btn btn-secondary"">Reddet</button>
                            <button type=""button"" class=""btn btn-primary"">Onayla</button>
                        </div>
                    </div>
                </div>

                <div class=""card custom-card"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Uygun Görülen Ödeme Tarihi:</h5>
                        <div class=""input-group date mb-1"" id=""datetimepicker"" data-target-input=""nearest"">
                            <input type=""date"" class=""form-control datetimepicker-input"" data-target=""#datetimepicker"" />
                        </div>
                        <div class=""d-flex jus");
            WriteLiteral(@"tify-content-between"">
                            <button type=""button"" class=""btn btn-secondary"">Formu Temizle</button>
                            <button type=""button"" class=""btn btn-primary"">Kaydet</button>
                        </div>
                    </div>
                </div>

                <div class=""card custom-card"">
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
      ");
            WriteLiteral(@"          </div>

                <div class=""card custom-card"">
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

            </div>
        </div>
    </div>
</div>

");
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
