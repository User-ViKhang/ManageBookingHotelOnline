#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ab91c407d021c9dd6370b08b59f6933baa801eb7abf1b24aecf89f7e76ff287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeOwner_Index), @"mvc.1.0.view", @"/Views/HomeOwner/Index.cshtml")]
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
#line 4 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\_ViewImports.cshtml"
using Booking_Frontend.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8ab91c407d021c9dd6370b08b59f6933baa801eb7abf1b24aecf89f7e76ff287", @"/Views/HomeOwner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c93967b2c4110f66ab46b8da40c5024caee8b3fc262835a4708f702e42e39ded", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HomeOwner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Index.cshtml"
  
    ViewData["Title"] = "Owner Home Page";
    Layout = "_LayoutOwner";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""layoutSidenav_content"">
    <div class=""container"">
        <div class=""homeowner-page"">
            <div class=""title-addbooking d-flex"">
                <div class=""title"">
                    <h3>Bảng thông báo đặt phòng</h3>
                </div>
                <div class=""addbooking"">
                    <div class=""btn btn-outline-primary"">Thêm đặt phòng</div>
                </div>
            </div>
        </div>
        <div class=""homeowner-table"">
            <table class=""table table-hover table-striped table-all-booking"">
                <thead>
                <th></th>
                <th class=""id-booking"">#Booking</th>
                <th>Đơn hàng</th>
                <th class=""number-guest"">Số khách</th>
                <th>Người đặt</th>
                <th>Trạng thái</th>
                <th>CheckIn</th>
                <th>CheckOut</th>
                </thead>
                <tbody>
                    <tr>
                        <td></td>
    ");
            WriteLiteral(@"                    <td>Booking - <a href=""#"" class=""underline-none"">#12340</a></td>
                        <td><a href=""#"" class=""underline-none"">Phòng Gia đình</a> </td>
                        <td>2</td>
                        <td><a href=""#"" class=""underline-none"">Hà Vĩ Khang (Guest) </a></td>
                        <td><a href=""#"" class=""underline-none"">#12340</a> - Pedding</td>
                        <td>11/11/2024</td>
                        <td>22/12/2024</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>Booking - <a href=""#"" class=""underline-none"">#12340</a></td>
                        <td><a href=""#"" class=""underline-none"">Phòng Gia đình</a> </td>
                        <td>2</td>
                        <td><a href=""#"" class=""underline-none"">Hà Vĩ Khang (Guest) </a></td>
                        <td><a href=""#"" class=""underline-none"">#12340</a> - Pedding</td>
                        <td>11/11/2024</td>
       ");
            WriteLiteral(@"                 <td>22/12/2024</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>Booking - <a href=""#"" class=""underline-none"">#12340</a></td>
                        <td><a href=""#"" class=""underline-none"">Phòng Gia đình</a> </td>
                        <td>2</td>
                        <td><a href=""#"" class=""underline-none"">Hà Vĩ Khang (Guest) </a></td>
                        <td><a href=""#"" class=""underline-none"">#12340</a> - Pedding</td>
                        <td>11/11/2024</td>
                        <td>22/12/2024</td>
                    </tr>
                </tbody>
                <tfoot>
                <th></th>
                <th class=""id-booking"">#Booking</th>
                <th>Đơn hàng</th>
                <th class=""number-guest"">Số khách</th>
                <th>Người đặt</th>
                <th>Trạng thái</th>
                <th>CheckIn</th>
                <th>CheckOut</th>
                <");
            WriteLiteral("/tfoot>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
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