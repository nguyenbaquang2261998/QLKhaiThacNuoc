#pragma checksum "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8494e3c7dd81ebbded2447a80cc8fa3a1e0a0796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToTrinh_Search), @"mvc.1.0.view", @"/Views/ToTrinh/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8494e3c7dd81ebbded2447a80cc8fa3a1e0a0796", @"/Views/ToTrinh/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_ToTrinh_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.ToTrinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/ToTrinh/Create"">Thêm tờ trình mới</a></span>
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""card-title"">Danh sách tờ trình</h3>

        <div class=""card-tools"">
");
#nullable restore
#line 12 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
             using (Html.BeginForm("Search", "ToTrinh", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 15 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
               Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"Tìm kiếm\" />\r\n                </p>\r\n");
#nullable restore
#line 17 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
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
                        Mã tờ trình
                    </th>
                    <th class=""text-center"">
                        Tên tờ trình
                    </th>
                    <th class=""text-center"">
                        Ngày tạo
                    </th>
                    <th class=""text-center"">
                        Tổ chức
                    </th>
                    <th class=""text-center"">
                        Vị tí khai thác
                    </th>
                    <th class=""text-center"">
                        Tầng chưa nước khai thác
                    </th>
                    <th class=""text-center"">
                        Ngày ban hành
                    </th>
                    <th class=""text-c");
            WriteLiteral("enter\">\r\n                        Trạng thái\r\n                    </th>\r\n                    <th class=\"text-center\">\r\n                        Thao tác\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 59 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TenToTrinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 65 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ToChuc.TenToChuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 71 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DonViHanhChinh.TenDonViHanhChinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 74 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TangChuaNuocKhaiThac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 77 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NgayBanHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n");
#nullable restore
#line 80 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                             if (item.TrangThai == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-warning\">Chờ duyệt</span>\r\n");
#nullable restore
#line 83 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                             if (item.TrangThai == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-success\">Đã duyệt</span>\r\n");
#nullable restore
#line 87 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                             if (item.TrangThai == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-danger\">Hủy</span>\r\n");
#nullable restore
#line 91 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td class=\"text-center\">\r\n");
#nullable restore
#line 94 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                             if (item.TrangThai == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 3991, "\"", 4022, 2);
            WriteAttributeValue("", 3998, "/ToTrinh/Update/", 3998, 16, true);
#nullable restore
#line 96 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
WriteAttributeValue("", 4014, item.Id, 4014, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xử lý</a></span>\r\n                                <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 4106, "\"", 4137, 2);
            WriteAttributeValue("", 4113, "/ToTrinh/Delete/", 4113, 16, true);
#nullable restore
#line 97 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
WriteAttributeValue("", 4129, item.Id, 4129, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n");
#nullable restore
#line 98 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 101 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-5\">\r\n                <div class=\"dataTables_info\" id=\"example2_info\" role=\"status\" aria-live=\"polite\">Hiển thị: ");
#nullable restore
#line 106 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.ToTrinh>> Html { get; private set; }
    }
}
#pragma warning restore 1591