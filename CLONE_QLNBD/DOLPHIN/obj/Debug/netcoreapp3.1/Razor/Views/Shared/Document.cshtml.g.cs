#pragma checksum "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Shared\Document.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "404c95a52217fcab6a1c3052f3ab48805349405e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Document), @"mvc.1.0.view", @"/Views/Shared/Document.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"404c95a52217fcab6a1c3052f3ab48805349405e", @"/Views/Shared/Document.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bfe1b367f9a07c07c313aef6d4d41b9edc5f731", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Document : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\h\Desktop\QL_KHAI_THAC_NƯỚC\QLKhaiThacNuoc\CLONE_QLNBD\DOLPHIN\Views\Shared\Document.cshtml"
  
    ViewData["Title"] = "Document";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card card-row card-default"">
    <div class=""card-header bg-info"">
        <h3 class=""card-title"">
            Tài liệu hướng dẫn cài đặt
        </h3>
    </div>
    <div class=""card-body"">
        <div class=""card card-light card-outline"">
            <div class=""card-header"">
                <h5 class=""card-title"">Bước 1</h5>
                <div class=""card-tools"">
                    <a href=""#"" class=""btn btn-tool btn-link"">#1</a>
                    <a href=""#"" class=""btn btn-tool"">
                        <i class=""fas fa-pen""></i>
                    </a>
                </div>
            </div>
            <div class=""card-body"">
                <p>
                    Các phần mềm cần cài đặt: Visual studio 2019 , xampp, Git
                    Clone code từ địa chỉ: https://github.com/nguyenbaquang2261998/QLKhaiThacNuoc/tree/master
                </p>
            </div>
        </div>
        <div class=""card card-light card-outline"">
            <div class=""");
            WriteLiteral(@"card-header"">
                <h5 class=""card-title"">Bước 2</h5>
                <div class=""card-tools"">
                    <a href=""#"" class=""btn btn-tool btn-link"">#1</a>
                    <a href=""#"" class=""btn btn-tool"">
                        <i class=""fas fa-pen""></i>
                    </a>
                </div>
            </div>
            <div class=""card-body"">
                <p>
                    Pull code branch master
                </p>
            </div>
        </div>
        <div class=""card card-light card-outline"">
            <div class=""card-header"">
                <h5 class=""card-title"">Bước 3</h5>
                <div class=""card-tools"">
                    <a href=""#"" class=""btn btn-tool btn-link"">#1</a>
                    <a href=""#"" class=""btn btn-tool"">
                        <i class=""fas fa-pen""></i>
                    </a>
                </div>
            </div>
            <div class=""card-body"">
                <p>
                 ");
            WriteLiteral(@"   Update database

                    - Vào file Startup.cs thay IServiceProvider thành void

                    Sau đó comment dòng return lại.

                    - Tiếp đến vào file Program.cs comment từ dòng 15-22 sau đó mở comment dòng 23-33.
                    - Build lại project.
                    - Trong tab Package manager console
                    Chọn Default project như hình trong khung đỏ
                    Thực hiện lệch Update-Database

                    Sau khi cập nhật Database thành công. Quay lại file Program.cs và Starup.cs để Undo lại hiện trạng ban đầu.
                </p>
            </div>
        </div>
        <div class=""card card-light card-outline"">
            <div class=""card-header"">
                <h5 class=""card-title"">Bước 4</h5>
                <div class=""card-tools"">
                    <a href=""#"" class=""btn btn-tool btn-link"">#1</a>
                    <a href=""#"" class=""btn btn-tool"">
                        <i class=""fas fa-pen""></i");
            WriteLiteral(@">
                    </a>
                </div>
            </div>
            <div class=""card-body"">
                <p>
                    Build Project xem có success không.
                    Run Project
                </p>
            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591