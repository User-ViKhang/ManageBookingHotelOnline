#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8cff0ee315459ce2f05f3ae55423e3ae083411c92756a049cd225b0ebb955b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeOwner_DisplayBill), @"mvc.1.0.view", @"/Views/HomeOwner/DisplayBill.cshtml")]
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
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
using Booking_Backend.Data.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
using Booking_Frontend.WebApp.Models.Owner;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"8cff0ee315459ce2f05f3ae55423e3ae083411c92756a049cd225b0ebb955b94", @"/Views/HomeOwner/DisplayBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4b599e0366a677a8ea3b9eec10ab2dceb089884055e7760cbfe0a588b4990470", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HomeOwner_DisplayBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotifyBookingViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/check-out/bill/confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-logout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
  
    ViewData["Title"] = "Owner Home Page";
    Layout = "_LayoutOwner";

#line default
#line hidden
#nullable disable
            WriteLiteral("﻿");
#nullable restore
#line 9 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
   
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .wrapper-info-client, .wrapper-info-hotel, .wrapper-info-fee {
        position: relative;
    }

        .wrapper-info-fee:before {
            position: absolute;
            content: ""Chi phí"";
            font-size: 14px;
            color: blue;
            top: -10px;
            right: 20px;
            padding: 0 10px;
            background-color: white;
        }

        .wrapper-info-client:before {
            position: absolute;
            content: ""Thông tin khách hàng"";
            font-size: 14px;
            color: blue;
            top: -10px;
            right: 20px;
            padding: 0 10px;
            background-color: white;
        }

        .wrapper-info-hotel:before {
            position: absolute;
            content: ""Thông tin chổ nghỉ"";
            font-size: 14px;
            color: blue;
            top: -10px;
            right: 20px;
            padding: 0 10px;
            background-color: white;
        }

    .pop");
            WriteLiteral(@"up {
        position: fixed;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        background-color: #fff;
        padding: 20px;
        border: 1px solid #ccc;
        border-radius: 5px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.3);
        display: none;
        z-index: 1000;
    }

    .popup-content {
        text-align: center;
    }

    .popup button {
        margin: 5px;
        padding: 10px 20px;
        cursor: pointer;
    }
</style>

<div id=""layoutSidenav_content"">
    <div class=""m-5"" style=""width:1000px; background-color: white; box-shadow: 0 0 5px 3px #d5d5da"">
        <div class=""bill-order p-3"" style=""height:100%"">
            <h3 class=""text-center"">Phiếu hóa đơn</h3>
            <div class=""col-md-12 mt-4"">
                <div class=""row"">
                    <div class=""col-md-6""");
            BeginWriteAttribute("style", " style=\"", 2218, "\"", 2226, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""wrapper-info-client p-3"" style=""border: thin solid #ccc; height: 100%; background-color: white; border-radius: 10px"">
                            <div class=""wrapper-info-name d-flex"">
                                <div style=""font-weight: 500"">Khách hàng:</div><span");
            BeginWriteAttribute("class", " class=\"", 2537, "\"", 2545, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 86 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-address\">\r\n                                <span style=\"font-weight: 500\">Địa chỉ:</span>\r\n                                <span> ");
#nullable restore
#line 90 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                  Write(Model.BillClientViewModel.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"wrapper-info-phone d-flex\">\r\n                                <div style=\"font-weight: 500\">Số điện thoại:</div>    <span");
            BeginWriteAttribute("class", " class=\"", 3112, "\"", 3120, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 94 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-email d-flex\">\r\n                                <div style=\"font-weight: 500\">Email:</div>   <span");
            BeginWriteAttribute("class", " class=\"", 3423, "\"", 3431, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 98 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-phone d-flex\">\r\n                                <div style=\"font-weight: 500\">Ngày đặt phòng:</div>   <span");
            BeginWriteAttribute("class", " class=\"", 3737, "\"", 3745, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 102 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.CreatedBooking.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-name d-flex\">\r\n                                <div style=\"font-weight: 500\">Ngày check-in:</div>   <span");
            BeginWriteAttribute("class", " class=\"", 4081, "\"", 4089, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">___</span>\r\n                                <div>");
#nullable restore
#line 106 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.Checkin.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-address d-flex\">\r\n                                <div style=\"font-weight: 500\">Ngày check-out:</div>   <span");
            BeginWriteAttribute("class", " class=\"", 4424, "\"", 4432, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">__</span>\r\n                                <div>");
#nullable restore
#line 110 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.BillClientViewModel.Checkout.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-md-6\"");
            BeginWriteAttribute("style", " style=\"", 4708, "\"", 4716, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""wrapper-info-hotel p-3"" style=""border: thin solid #ccc; height: 100%; background-color: white; border-radius: 10px"">
                            <div class=""wrapper-info-phone d-flex"">
                                <div style=""font-weight: 500"">Chỗ nghỉ:</div>   <span");
            BeginWriteAttribute("class", " class=\"", 5028, "\"", 5036, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 119 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.HotelViewModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-name\">\r\n                                <span style=\"font-weight: 500\">Địa chỉ:</span>\r\n                                <span>");
#nullable restore
#line 123 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                 Write(Model.HotelViewModel.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"wrapper-info-address d-flex\">\r\n                                <div style=\"font-weight: 500\">Hotline:</div>    <span");
            BeginWriteAttribute("class", " class=\"", 5585, "\"", 5593, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>");
#nullable restore
#line 127 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                Write(Model.HotelViewModel.Hotline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-email d-flex\">\r\n                                <div style=\"font-weight: 500\">Email:</div>     <span");
            BeginWriteAttribute("class", " class=\"", 5889, "\"", 5897, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: white"">_</span>
                                <div>vikhang11112002@gmail.com</div>
                            </div>
                            <div class=""wrapper-info-email  d-flex"">
                                <div style=""font-weight: 500"">Website:</div>     <span");
            BeginWriteAttribute("class", " class=\"", 6192, "\"", 6200, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>vikhang11112002@gmail.com</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6 mt-3\"");
            BeginWriteAttribute("style", " style=\"", 6445, "\"", 6453, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""wrapper-info-fee p-3"" style=""border: thin solid #ccc; height: 100%; background-color: white; border-radius: 10px"">
                            <div class=""wrapper-info-phone  d-flex"">
                                <div style=""font-weight: 500"">Phụ thu:</div>    <span");
            BeginWriteAttribute("class", " class=\"", 6764, "\"", 6772, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: white"">_</span>
                                <div class=""pl-2"">không có</div>
                            </div>
                            <div class=""wrapper-info-name  d-flex"">
                                <div style=""font-weight: 500""");
            BeginWriteAttribute("class", " class=\"", 7037, "\"", 7045, 0);
            EndWriteAttribute();
            WriteLiteral(">Phí Gonow.net: </div>   <span");
            BeginWriteAttribute("class", " class=\"", 7076, "\"", 7084, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>miễn phí</div>\r\n                            </div>\r\n                            <div class=\"wrapper-info-name  d-flex\">\r\n                                <div style=\"font-weight: 500\"");
            BeginWriteAttribute("class", " class=\"", 7336, "\"", 7344, 0);
            EndWriteAttribute();
            WriteLiteral(">VAT:</div>           <span");
            BeginWriteAttribute("class", " class=\"", 7372, "\"", 7380, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: white"">_</span>
                                <div> Không tính</div>
                            </div>  
                            <div class=""wrapper-info-name  d-flex"">
                                <div style=""font-weight: 500""");
            BeginWriteAttribute("class", " class=\"", 7637, "\"", 7645, 0);
            EndWriteAttribute();
            WriteLiteral(">Phương thức thanh toán:</div>           <span");
            BeginWriteAttribute("class", " class=\"", 7692, "\"", 7700, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""color: white"">_</span>
                                <div> thanh toán tại quầy</div>
                            </div>
                            <div class=""wrapper-info-name  d-flex"">
                                <div style=""font-weight: 500""");
            BeginWriteAttribute("class", " class=\"", 7964, "\"", 7972, 0);
            EndWriteAttribute();
            WriteLiteral(">Tổng hóa đơn: </div>  <span");
            BeginWriteAttribute("class", " class=\"", 8001, "\"", 8009, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: white\">_</span>\r\n                                <div>\r\n                                    <div class=\"ml-3\">\r\n                                        ");
#nullable restore
#line 161 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                    Write(Model.BillClientViewModel.TotalBill.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6 mt-3\"");
            BeginWriteAttribute("style", " style=\"", 8464, "\"", 8472, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""wrapper-info"" style="" height: 100%"">
                            <table class=""table table-bordered"" style=""background-color: white"">
                                <thead style=""font-size: 14px; font-weight: 300"">
                                <th style="" font-weight: 400"">SL</th>
                                <th style="" font-weight: 400"">Phòng</th>
                                <th style="" font-weight: 400"">Loại</th>
                                <th style="" font-weight: 400"">Giường</th>
                                <th style="" font-weight: 400"">Đơn giá</th>
                                </thead>
                                <tbody style=""font-size: 12px"">
");
#nullable restore
#line 179 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                     foreach (var item in Model.BillClientViewModel.RoomBills)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th style=\" font-weight: 300\">1</th>\r\n                                            <th style=\" font-weight: 300\">");
#nullable restore
#line 183 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                                                     Write(item.RoomCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th style=\" font-weight: 300\">");
#nullable restore
#line 184 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                                                     Write(item.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th style=\" font-weight: 300\">");
#nullable restore
#line 185 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                                                     Write(item.BedName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th style=\" font-weight: 300\">");
#nullable restore
#line 186 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                                                      Write(item.Price.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VND</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 188 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 10069, "\"", 10077, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 100px; width: 100px; border: thin solid #ccc\">\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 10282, "\"", 10289, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration: none"">
                <div class=""mt-3 btn btn-outline-primary"">Hủy</div>

                </a>
                <button onclick=""showLogoutPopup()"" class=""mt-3 btn btn-primary"">Xác nhận hóa đơn</button>
            </div>

            <div id=""confimPopup"" class=""popup"" style=""display: none;"">
                <div class=""popup-content"">
                    <p>Xác nhận trả phòng?</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cff0ee315459ce2f05f3ae55423e3ae083411c92756a049cd225b0ebb955b9423888", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 10848, "\"", 10892, 1);
#nullable restore
#line 208 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
WriteAttributeValue("", 10856, Model.BillClientViewModel.BookingId, 10856, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"BookingId\" />\r\n                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 10959, "\"", 11027, 1);
#nullable restore
#line 209 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\HomeOwner\DisplayBill.cshtml"
WriteAttributeValue("", 10967, Model.BillClientViewModel.RoomBills.FirstOrDefault().RoomId, 10967, 60, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"RoomId\" />\r\n                        <button class=\"btn btn-outline-danger\" onclick=\"cancelLogout()\">Không</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary\" onclick=\"logout()\">Xác nhận</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>









<script>
    function showLogoutPopup() {
        document.getElementById(""confimPopup"").style.display = ""block"";
    }

    function cancelLogout() {
        document.getElementById(""confimPopup"").style.display = ""none"";
    }

    function logout() {
        var form = document.getElementById('form-logout'); // Thay 'yourFormId' bằng id thực của form
        form.submit();
    }

</script>");
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
