#pragma checksum "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465ba8ab7eab65ec2691b8ae6fa8a7166e1f4b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToChuc_Search), @"mvc.1.0.view", @"/Views/ToChuc/Search.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"465ba8ab7eab65ec2691b8ae6fa8a7166e1f4b56", @"/Views/ToChuc/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_ToChuc_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.ToChuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
  
    string name = string.Empty;
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/ToChuc/Create"">Thêm tổ chức</a></span>
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Danh sách Tổ chức</h3>

        <div class=""card-tools"">
");
#nullable restore
#line 13 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
             using (Html.BeginForm("Search", "ToChuc", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 16 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
               Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"Tìm kiếm\" />\r\n                </p>\r\n");
#nullable restore
#line 18 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <!-- /.card-header -->
    <div class=""card-body table-responsive p-0"">
        <table class=""table table-hover text-nowrap"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Mã tổ chức
                    </th>
                    <th class=""text-center"">
                        Tên tổ chức
                    </th>
                    <th class=""text-center"">
                        Địa chỉ
                    </th>
                    <th class=""text-center"">
                        Số điện thoại
                    </th>
                    <th class=""text-center"">
                        Thao tác
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TenToChuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SoDienThoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2291, "\"", 2319, 2);
            WriteAttributeValue("", 2298, "/ToChuc/Edit/", 2298, 13, true);
#nullable restore
#line 60 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
WriteAttributeValue("", 2311, item.Id, 2311, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span>\r\n                            <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2397, "\"", 2427, 2);
            WriteAttributeValue("", 2404, "/ToChuc/Delete/", 2404, 15, true);
#nullable restore
#line 61 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
WriteAttributeValue("", 2419, item.Id, 2419, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 64 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-5\">\r\n                <div class=\"dataTables_info\" id=\"example2_info\" role=\"status\" aria-live=\"polite\">Hiển thị: ");
#nullable restore
#line 69 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToChuc\Search.cshtml"
                                                                                                      Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" bản ghi</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.card-body -->\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.ToChuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591