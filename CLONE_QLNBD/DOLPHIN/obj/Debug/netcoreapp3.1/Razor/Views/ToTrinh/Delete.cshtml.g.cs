#pragma checksum "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a34fc969fb7320857437a68d782115830688f8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToTrinh_Delete), @"mvc.1.0.view", @"/Views/ToTrinh/Delete.cshtml")]
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
#line 1 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\_ViewImports.cshtml"
using DOLPHIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a34fc969fb7320857437a68d782115830688f8d", @"/Views/ToTrinh/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_ToTrinh_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.ToTrinh>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"margin-left:20px ; margin-top:20px\">Bạn có chắc chắn muốn xóa ");
#nullable restore
#line 7 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml"
                                                                    Write(Model.TenToTrinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n<div class=\"card\">\r\n");
#nullable restore
#line 9 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Xóa\" class=\"btn btn-danger\" style=\"margin-left:20px\" />\r\n        <a href=\"/ToTrinh/Index\" class=\"btn btn-primary\" style=\"margin-left:20px\">Quay lại</a>\r\n");
#nullable restore
#line 15 "C:\Users\nguye\OneDrive\Documents\Máy tính\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\ToTrinh\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.ToTrinh> Html { get; private set; }
    }
}
#pragma warning restore 1591
