#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ConfirmInfo), @"mvc.1.0.view", @"/Views/Booking/ConfirmInfo.cshtml")]
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
#line 1 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
using Booking_Backend.Repository.BookingRepo.Request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
using Booking_Backend.Repository.BookingRepo.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c2", @"/Views/Booking/ConfirmInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"c93967b2c4110f66ab46b8da40c5024caee8b3fc262835a4708f702e42e39ded", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Booking_ConfirmInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateBookingRequest>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Việt Nam", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
  
    var culture = CultureInfo.CurrentCulture.Name;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutProcessBooking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container pt-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c25806", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"RoomId\"");
                BeginWriteAttribute("value", " value=\"", 584, "\"", 605, 1);
#nullable restore
#line 16 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 592, Model.RoomId, 592, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"HotelId\"");
                BeginWriteAttribute("value", " value=\"", 658, "\"", 680, 1);
#nullable restore
#line 17 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 666, Model.HotelId, 666, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"LanguageId\"");
                BeginWriteAttribute("value", " value=\"", 736, "\"", 752, 1);
#nullable restore
#line 18 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 744, culture, 744, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
            <div class=""row"">
            <div class=""col-md-8"">
                <div class=""form-info-cus"">
                    <h5>Hãy cho chúng tôi biết bạn là ai?</h5>
                    <div class=""fullname-info mt-4"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 1018, "\"", 1024, 0);
                EndWriteAttribute();
                WriteLiteral(">Họ tên khách hàng</label>\r\n                        <input type=\"text\" name=\"FullName\" class=\"form-control\">       <!--FullName-->\r\n                    </div>\r\n                    <div class=\"email-info mt-4\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1266, "\"", 1272, 0);
                EndWriteAttribute();
                WriteLiteral(@">Email khách hàng</label>
                        <input type=""email"" name=""Email"" class=""form-control"">              <!--Email-->
                    </div>
                    <div class=""row mt-4"">
                        <div class=""col-md-6"">
                            <div class=""phone-info"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 1618, "\"", 1624, 0);
                EndWriteAttribute();
                WriteLiteral(@">Số điện thoại</label>
                                <input type=""tel"" name=""PhoneNumber"" class=""form-control"">  <!--PhoneNumber-->
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""nation-info"">
                                <label");
                BeginWriteAttribute("for", " for=\"", 1970, "\"", 1976, 0);
                EndWriteAttribute();
                WriteLiteral(">Quốc tịch</label>\r\n                                <select class=\"form-control\" name=\"Nation\">                               <!--Nation-->\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c29443", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c210721", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce02d7badf229522471861dadaa0e097e1f10d62ebfa70e7b21c1eff26d88c211791", async() => {
                    WriteLiteral("1");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                    </div>
                    <p class=""mt-3"">Nếu bạn nhập địa chỉ email của mình và không hoàn tất việc đặt chỗ, chúng tôi có thể gửi cho bạn lời nhắc để giúp bạn tiếp tục việc đặt chỗ.</p>
                    <div class=""note-text mt-3"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 2704, "\"", 2710, 0);
                EndWriteAttribute();
                WriteLiteral(@">Bổ sung yêu cầu</label>
                        <textarea name=""Note""></textarea>                <!--Note-->
                    </div>
                    <button class=""btn btn-primary"" type=""submit"">Tiếp tục đặt phòng</button>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""row"">
                    <div class=""col-md-12 d-flex pb-3"">
                        <div class=""info-hotel "">
                            <div class=""d-flex justify-content-between"">
                                <h5 class=""mb-1 pr-3"">");
#nullable restore
#line 62 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                 Write(Model.HotelName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
                                <div class=""d-flex align-items-center text-light"" style=""padding: 10px; height: 40px; background-color: #3888bd"" class=""text-light"">9.1</div>
                            </div>
                            <div class=""order-room"">
                            </div>
                            <div class=""row mt-3"">
                                <div class=""col-md-5"">
                                    <img style=""width: 100%"" src=""../../img/location/biet-thu-dep.png""");
                BeginWriteAttribute("alt", " alt=\"", 3831, "\"", 3837, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"col-md-7\">\r\n                                    <div style=\"font-size: 12px;\">");
#nullable restore
#line 72 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                             Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                    <div style=\"font-size: 14px; color: red; font-weight: 500\">");
#nullable restore
#line 73 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                                                          Write(Model.Hotline);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12  pb-3 d-flex"">
                        <div class=""info-hotel "">
                            <div class=""d-flex"">
                                <h5 class=""pr-2"">");
#nullable restore
#line 81 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                            Write(ViewData["DateCheckIn"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5> -\r\n                                <h5 class=\"pl-2 pr-3\">");
#nullable restore
#line 82 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                 Write(ViewData["DateCheckOut"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4657, "\"", 4689, 1);
#nullable restore
#line 83 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 4665, ViewData["DateCheckIn"], 4665, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"CheckIn\" />\r\n                                <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4762, "\"", 4795, 1);
#nullable restore
#line 84 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 4770, ViewData["DateCheckOut"], 4770, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""CheckOut"" />
                                <div style=""padding: 5px; height: 35px; background-color: #3888bd"" class=""text-light"">2N1D</div>
                            </div>
                            <div class=""order-room"">
                            </div>
                            <div class=""row mt-3"">
                                <div class=""col-md-5"">
                                    <img style=""width: 100%"" src=""../../img/location/biet-thu-dep.png""");
                BeginWriteAttribute("alt", " alt=\"", 5283, "\"", 5289, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"col-md-7\">\r\n                                    <h6 class=\"room-name\">");
#nullable restore
#line 94 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                     Write(Model.RoomTypeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 95 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                   Write(Model.BedName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <h6>");
#nullable restore
#line 96 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                   Write(ViewData["TotalPeople"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 d-flex"">
                        <div class=""info-hotel "">
                            <div class=""d-flex"">
                                <h5 class=""pr-2"">Phiếu thanh toán</h5>
                            </div>
                            <div class=""order-room"">
                            </div>
                            <div class=""row mt-3"">
                                <div class=""col-md-12 order-room"">
                                    <h6 class=""room-name"">Số lượng phòng: ");
#nullable restore
#line 110 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                                                     Write(Model.RoomQuality);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <input type=\"hidden\" name=\"TotalRoom\"");
                BeginWriteAttribute("value", " value=\"", 6384, "\"", 6410, 1);
#nullable restore
#line 111 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 6392, Model.RoomQuality, 6392, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <h6>Giá gốc: ");
#nullable restore
#line 112 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n                                    <input type=\"hidden\" name=\"Price\"");
                BeginWriteAttribute("value", " value=\"", 6553, "\"", 6573, 1);
#nullable restore
#line 113 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Booking\ConfirmInfo.cshtml"
WriteAttributeValue("", 6561, Model.Price, 6561, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                                </div>
                                <h6 class=""p-3"">Tổng thanh toán:</h6>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n   ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateBookingRequest> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591