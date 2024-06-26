#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6473bfdf36a4046e3ed08d94c8927df9f1fd3dd0bbafd835193623a1852923b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeOwner_CheckoutBooking), @"mvc.1.0.view", @"/Views/HomeOwner/CheckoutBooking.cshtml")]
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
#nullable restore
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
using Booking_Backend.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
using Booking_Frontend.WebApp.Models.Owner;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6473bfdf36a4046e3ed08d94c8927df9f1fd3dd0bbafd835193623a1852923b1", @"/Views/HomeOwner/CheckoutBooking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4b599e0366a677a8ea3b9eec10ab2dceb089884055e7760cbfe0a588b4990470", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HomeOwner_CheckoutBooking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotifyBookingViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/check-out/bill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
  
    ViewData["Title"] = "Owner Home Page";
    Layout = "_LayoutOwner";

#line default
#line hidden
#nullable disable
            WriteLiteral("﻿");
#nullable restore
#line 9 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
   
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""layoutSidenav_content"">
    <div class=""container"">
        <div class=""homeowner-page"">
            <div class=""title-addbooking d-flex"">
                <div class=""title"">
                    <h3>Bảng thông báo trả phòng</h3>
                </div>
            </div>
        </div>

        <div class=""homeowner-table mt-3"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6473bfdf36a4046e3ed08d94c8927df9f1fd3dd0bbafd835193623a1852923b15507", async() => {
                WriteLiteral(@"
                <table class=""table table-hover"" style=""font-size: 13px"">
                    <thead style=""background-color: #f6f8fa"">
                        <th style=""font-weight: 600""></th>
                        <th style=""font-weight: 600"" class=""id-booking"">#Booking</th>
                        <th style=""font-weight: 600"">Đơn hàng</th>
                        <th style=""font-weight: 600"">Mã phòng </th>
                        <th style=""font-weight: 600"" class=""number-guest"">Số khách</th>
                        <th style=""font-weight: 600"">Người đặt</th>
                        <th style=""font-weight: 600"">Ngày tạo</th>
                        <th style=""font-weight: 600"">Tổng tiền</th>
                        <th style=""font-weight: 600"">Trả phòng</th>
                    </thead>
                    <tbody>
");
#nullable restore
#line 38 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                          
                            foreach (var item in Model.BookingOwnerViewModel)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1797, "\"", 1813, 1);
#nullable restore
#line 42 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
WriteAttributeValue("", 1805, item.Id, 1805, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"BookingId\"/>\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1891, "\"", 1912, 1);
#nullable restore
#line 43 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
WriteAttributeValue("", 1899, item.Room.Id, 1899, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"RoomId\"/>\r\n                                    <td></td>\r\n                                    <td>Booking - <a");
                BeginWriteAttribute("href", " href=\"", 2030, "\"", 2061, 2);
                WriteAttributeValue("", 2037, "/detail-booking/", 2037, 16, true);
#nullable restore
#line 45 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
WriteAttributeValue("", 2053, item.Id, 2053, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"underline-none\">#");
#nullable restore
#line 45 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 2148, "\"", 2179, 2);
                WriteAttributeValue("", 2155, "/detail-booking/", 2155, 16, true);
#nullable restore
#line 46 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
WriteAttributeValue("", 2171, item.Id, 2171, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"underline-none\">");
#nullable restore
#line 46 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                                                                             Write(item.RoomType.RoomTypeTranslations.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> </td>\r\n                                    <td>");
#nullable restore
#line 47 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                   Write(item.Room.RoomCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>x ");
#nullable restore
#line 48 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                     Write(item.TotalPeople);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"bi bi-person-fill\"></i></td>\r\n                                    <td><a");
                BeginWriteAttribute("href", " href=\"", 2481, "\"", 2512, 2);
                WriteAttributeValue("", 2488, "/detail-booking/", 2488, 16, true);
#nullable restore
#line 49 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
WriteAttributeValue("", 2504, item.Id, 2504, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"underline-none\">\r\n");
#nullable restore
#line 50 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                              
                                                string UserName;
                                                if (item.GuestCustomer != null)
                                                {
                                                    UserName = @item.GuestCustomer.FullName + " - (Guest)";
                                                }
                                                else
                                                {
                                                    UserName = @item.User.UserName;
                                                }
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                                 Write(UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </a></td>\r\n                                    <td>");
#nullable restore
#line 63 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                   Write(item.Created.ToString("dd/MM/yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 65 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                                   Write(item.TotalAmount.ToString("N0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                    <td><button type=\"submit\" class=\"btn btn-primary\">Trả phòng</button></td>\r\n                                </tr>\r\n");
#nullable restore
#line 69 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\CheckoutBooking.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                    <tfoot style=""background-color: #f6f8fa"">
                        <th style=""font-weight: 600""></th>
                        <th style=""font-weight: 600"" class=""id-booking"">#Booking</th>
                        <th style=""font-weight: 600"">Đơn hàng</th>
                    <th style=""font-weight: 600"">Mã phòng </th>
                        <th style=""font-weight: 600"" class=""number-guest"">Số khách</th>
                        <th style=""font-weight: 600"">Người đặt</th>
                    <th style=""font-weight: 600"">Ngày tạo</th>
                    <th style=""font-weight: 600"">Tổng tiền</th>

                        <th style=""font-weight: 600"">Trả phòng</th>
                    </tfoot>
                </table>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotifyBookingViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
