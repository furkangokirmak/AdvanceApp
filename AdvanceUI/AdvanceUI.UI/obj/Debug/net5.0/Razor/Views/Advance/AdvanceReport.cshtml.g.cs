#pragma checksum "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "97b0391c51d9b6c588632c397c3cee4e9333d982026b078066b2aaab5252582a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advance_AdvanceReport), @"mvc.1.0.view", @"/Views/Advance/AdvanceReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"97b0391c51d9b6c588632c397c3cee4e9333d982026b078066b2aaab5252582a", @"/Views/Advance/AdvanceReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6fbe7050065225e7dd421baa0a72d039bba0fadee7a95901eaaeff85c81e4e75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Advance_AdvanceReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AdvanceSelectDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
  
    ViewData["Title"] = "Avans Talep Rapor Alma";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container col-md-12"">
    <div class=""card"">
        <div class=""card-body table-border-style"">
            <div class=""btn-group"" role=""group"" aria-label=""Dosya İşlemleri"">
                <button type=""button"" class=""btn btn-secondary"">
                    <i class=""fas fa-file-pdf""></i> PDF Rapor
                </button>
                <button type=""button"" class=""btn btn-secondary"">
                    <i class=""fas fa-file-excel""></i> Excel Rapor
                </button>
            </div>
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
                   ");
            WriteLiteral(@"         <th>Proje</th>
                            <th>Talep Durumu</th>
                            <th>Onaylayan<br />Reddeden</th>
                            <th>Onay/Red<br />Ünvan</th>
                            <th>Onay/Red<br />Tarihi</th>
                            <th>Onaylanan<br />Tutar</th>
                            <th>Belirlenen<br />Ödeme<br />Tarihi</th>
                            <th>Ödeme<br />Yapılan<br />Tarih</th>
                            <th>Geri Ödeme Durumu</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 42 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                                   Write(item.Employee.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.Employee.Title.TitleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.Employee.BusinessUnit.BusinessUnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(Math.Round(item.AdvanceAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n                                <td>");
#nullable restore
#line 46 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.RequestDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.DesiredDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.Project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.Status.StatusName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 50 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Transactor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                                                                      Write(item.AdvanceHistories.LastOrDefault().Transactor.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Transactor.Title.TitleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(item.AdvanceHistories.LastOrDefault().Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                               Write(Math.Round(@item.AdvanceHistories.LastOrDefault().ApprovedAmount.Value, 0));

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</td>\r\n\r\n                                <td>\r\n");
#nullable restore
#line 56 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                     if (item.Payments != null && item.Payments.Any())
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                   Write(item.Payments.FirstOrDefault().DeterminedPaymentDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                                                                                                          
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n                                <td>\r\n");
#nullable restore
#line 63 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                     if (item.Receipts != null && item.Receipts.Any(x => x.IsRefundReceipt == false))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                   Write(item.Receipts.FirstOrDefault(x => x.IsRefundReceipt == false).Date.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                                                                                                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n");
#nullable restore
#line 69 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                 if (!item.Payments.Any())
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td></td>\r\n");
#nullable restore
#line 72 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                }
                                else if (item.Receipts != null && item.Receipts.Any(x => x.IsRefundReceipt == true))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Geri Ödeme Yapıldı</td>\r\n");
#nullable restore
#line 76 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Geri Ödeme Yapılmadı</td>\r\n");
#nullable restore
#line 80 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tr>\r\n");
#nullable restore
#line 83 "C:\Users\furka\source\repos\Advance\AdvanceApp\AdvanceUI\AdvanceUI.UI\Views\Advance\AdvanceReport.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/2.3.1/jspdf.umd.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.17.0/xlsx.full.min.js""></script>

<script>
    // Tabloyu veri olarak almak için bir fonksiyon
    function getTableData(table) {
        var data = [];
        // Tablonun başlıklarını almak
        var headers = [];
        table.querySelectorAll(""th"").forEach(function (header) {
            headers.push(header.innerText);
        });
        data.push(headers);
        // Tablonun satırlarını almak
        table.querySelectorAll(""tbody tr"").forEach(function (row) {
            var rowData = [];
            row.querySelectorAll(""td"").forEach(function (cell) {
                rowData.push(cell.innerText);
            });
            data.push(rowData);
        });
        return data;
    }

    // Tabloyu PDF dosyasına dö");
            WriteLiteral(@"nüştürmek için bir fonksiyon
    function exportTableToPDF(table) {
        // jsPDF nesnesi oluşturmak
        var doc = new jsPDF();
        // Tablo verisini almak
        var data = getTableData(table);
        // Tabloyu PDF dosyasına yazdırmak
        doc.autoTable({
            head: data.slice(0, 1),
            body: data.slice(1),
        });
        // PDF dosyasını indirmek
        doc.save(""Avans_Talep_Raporu.pdf"");
    }

    // Tabloyu Excel dosyasına dönüştürmek için bir fonksiyon
    function exportTableToExcel(table) {
        // SheetJS nesnesi oluşturmak
        var wb = XLSX.utils.book_new();
        // Tablo verisini almak
        var data = getTableData(table);
        // Tabloyu bir çalışma sayfasına dönüştürmek
        var ws = XLSX.utils.aoa_to_sheet(data);
        // Çalışma sayfasını çalışma kitabına eklemek
        XLSX.utils.book_append_sheet(wb, ws, ""Avans Talep Raporu"");
        // Excel dosyasını indirmek
        XLSX.writeFile(wb, ""Avans_Talep_Raporu");
            WriteLiteral(@".xlsx"");
    }

    // Butonlara tıklama olaylarını tanımlamak
    var table = document.querySelector(""table""); // Tabloyu seçmek
    var pdfButton = document.querySelector("".btn-group button:first-child""); // PDF butonunu seçmek
    var excelButton = document.querySelector("".btn-group button:last-child""); // Excel butonunu seçmek

    // PDF butonuna tıklandığında, tabloyu PDF dosyasına dönüştürmek
    pdfButton.addEventListener(""click"", function () {
        exportTableToPDF(table);
    });

    // Excel butonuna tıklandığında, tabloyu Excel dosyasına dönüştürmek
    excelButton.addEventListener(""click"", function () {
        exportTableToExcel(table);
    });

</script>");
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
