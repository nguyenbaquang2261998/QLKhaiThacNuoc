#pragma checksum "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83102f6615970e4d5183fb2375448c57b1739340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DonViHanhChinh_Index), @"mvc.1.0.view", @"/Views/DonViHanhChinh/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83102f6615970e4d5183fb2375448c57b1739340", @"/Views/DonViHanhChinh/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_DonViHanhChinh_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.DonViHanhChinh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h3 class=\"card-title\">Danh sách đơn vị hành chính tỉnh Bình Dương</h3>\r\n\r\n        <div class=\"card-tools\">\r\n");
#nullable restore
#line 16 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
             using (Html.BeginForm("Search", "DonViHanhChinh", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 19 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
               Write(Html.TextBox("name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"Tìm kiếm\" />\r\n                </p>\r\n");
#nullable restore
#line 21 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
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
                        Mã đơn vị
                    </th>
                    <th class=""text-center"">
                        Tên xã, phường, thị trấn
                    </th>
                    <th class=""text-center"">
                        Tọa độ
                    </th>
                    <th class=""text-center"">
                        Thao tác
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 48 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 51 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TenDonViHanhChinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ToaDo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td class=\"text-center\">\r\n                            <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 1984, "\"", 2020, 2);
            WriteAttributeValue("", 1991, "/DonViHanhChinh/Edit/", 1991, 21, true);
#nullable restore
#line 56 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
WriteAttributeValue("", 2012, item.Id, 2012, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span>\r\n                            <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2098, "\"", 2136, 2);
            WriteAttributeValue("", 2105, "/DonViHanhChinh/Delete/", 2105, 23, true);
#nullable restore
#line 57 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
WriteAttributeValue("", 2128, item.Id, 2128, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-12 col-md-5\">\r\n                <div class=\"dataTables_info\" id=\"example2_info\" role=\"status\" aria-live=\"polite\">Hiển thị : ");
#nullable restore
#line 65 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\DonViHanhChinh\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.DonViHanhChinh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
