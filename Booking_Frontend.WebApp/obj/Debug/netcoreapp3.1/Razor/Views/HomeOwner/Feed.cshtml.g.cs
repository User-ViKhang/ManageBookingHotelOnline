#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "aaf756164806b1a1264809b23e82b74d89c647801a8bb3b6452a8713bae5a1e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeOwner_Feed), @"mvc.1.0.view", @"/Views/HomeOwner/Feed.cshtml")]
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
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
using Booking_Backend.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
using Booking_Frontend.WebApp.Models.Owner;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"aaf756164806b1a1264809b23e82b74d89c647801a8bb3b6452a8713bae5a1e0", @"/Views/HomeOwner/Feed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4b599e0366a677a8ea3b9eec10ab2dceb089884055e7760cbfe0a588b4990470", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HomeOwner_Feed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotifyBookingViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
  
    ViewData["Title"] = "Owner Home Page";
    Layout = "_LayoutOwner";

#line default
#line hidden
#nullable disable
            WriteLiteral("﻿");
#nullable restore
#line 9 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
   
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""layoutSidenav_content"">
    <div style=""position: fixed"">
        <script>
            var connection = new signalR.HubConnectionBuilder().withUrl(""/notificationHub"").build();
            connection.on(""ReceiveNotification"", function (hotelId, message) {
                if (parseInt(hotelId) === ");
#nullable restore
#line 18 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                     Write(Model.HotelViewModel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@") {
                    var audio = new Audio(""/audio/livechat-129007.mp3"");
                    audio.play()
                    Swal.fire({
                        title: 'Thông báo đặt phòng mới!',
                        text: message,
                        icon: 'info',
                        confirmButtonText: 'OK'
                    }).then((result) => {
                        if (result.isConfirmed) {
                            location.reload();
                        }
                    });
                }
            });
            connection.start().catch(function (err) {
                return console.error(err.toString());
            });
        </script>
    </div>
    <div class=""container"">
        <div class=""homeowner-page"">
            <div class=""title-addbooking d-flex"">
                <div class=""title"">
                    <h3>Bảng tin đặt phòng - ");
#nullable restore
#line 42 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                        Write(DateTime.UtcNow.ToString("d/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                </div>
            </div>
        </div>

        <div class=""homeowner-table mt-3"">
            <table class=""table table-hover"" style=""font-size: 13px"">
                <thead style=""background-color: #f6f8fa"">
                <th style=""font-weight: 600""></th>
                <th style=""font-weight: 600"" class=""id-booking"">#Booking</th>
                <th style=""font-weight: 600"">Đơn hàng</th>
                <th style=""font-weight: 600"" class=""number-guest"">Số khách</th>
                <th style=""font-weight: 600"">Người đặt</th>
                <th style=""font-weight: 600"">Ngày đặt hàng</th>
                <th style=""font-weight: 600"">Ngày check-in</th>
                <th style=""font-weight: 600"">Ngày check-out</th>
                </thead>
                <tbody>
");
#nullable restore
#line 60 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                      
                        foreach (var item in Model.BookingOwnerViewModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\r\n                                                                    <td></td>\r\n                                                                    <td>Booking - <a");
            BeginWriteAttribute("href", " href=\"", 2788, "\"", 2819, 2);
            WriteAttributeValue("", 2795, "/detail-booking/", 2795, 16, true);
#nullable restore
#line 65 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
WriteAttributeValue("", 2811, item.Id, 2811, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"underline-none\">#");
#nullable restore
#line 65 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 2938, "\"", 2969, 2);
            WriteAttributeValue("", 2945, "/detail-booking/", 2945, 16, true);
#nullable restore
#line 66 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
WriteAttributeValue("", 2961, item.Id, 2961, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"underline-none\">");
#nullable restore
#line 66 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                             Write(item.RoomType.RoomTypeTranslations.FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </td>\r\n                                                                    <td>x ");
#nullable restore
#line 67 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                     Write(item.TotalPeople);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"bi bi-person-fill\"></i></td>\r\n                                                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 3269, "\"", 3300, 2);
            WriteAttributeValue("", 3276, "/detail-booking/", 3276, 16, true);
#nullable restore
#line 68 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
WriteAttributeValue("", 3292, item.Id, 3292, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"underline-none\">\r\n");
#nullable restore
#line 69 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                              
                                            if(item.User != null)
                                            {
                                                                                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                         Write(item.User.UserName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                                                        
                                            } else
                                            {
                                                                                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                         Write(item.GuestCustomer.FullName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                                                                                                                 
                                            }
                                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                    </a></td>\r\n                                                                    <td>");
#nullable restore
#line 79 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                   Write(item.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 80 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                   Write(item.CheckIn.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 81 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                                   Write(item.CheckOut.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 83 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot style=""background-color: #f6f8fa"">
                <th style=""font-weight: 600""></th>
                <th style=""font-weight: 600"" class=""id-booking"">#Booking</th>
                <th style=""font-weight: 600"">Đơn hàng</th>
                <th style=""font-weight: 600"" class=""number-guest"">Số khách</th>
                <th style=""font-weight: 600"">Người đặt</th>
                <th style=""font-weight: 600"">Ngày đặt hàng</th>
                <th style=""font-weight: 600"">Ngày check-in</th>
                <th style=""font-weight: 600"">Ngày check-out</th>
                </tfoot>
            </table>

        </div>
    </div>
</div>
<script>
    const statusSelect = document.getElementById('statusSelect');
    const filterLink = document.getElementById('filterLink');

    // Thêm sự kiện onclick cho thẻ a
    statusSelect.onchange = function () {
        const selectedStatus = statusSelect.value;
        filterLink.href = ""/");
#nullable restore
#line 108 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                       Write(culture);

#line default
#line hidden
#nullable disable
            WriteLiteral("/homeowner/index/");
#nullable restore
#line 108 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\Feed.cshtml"
                                                Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("?status=\" + selectedStatus;\r\n        filterLink.click()\r\n        filterLink.textContent = selectedStatus === \"\" ? \"Trạng thái đặt phòng\" : selectedStatus;\r\n    };\r\n</script>");
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
