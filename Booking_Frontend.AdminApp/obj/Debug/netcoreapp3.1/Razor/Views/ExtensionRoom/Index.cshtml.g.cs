#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExtensionRoom_Index), @"mvc.1.0.view", @"/Views/ExtensionRoom/Index.cshtml")]
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
#line 1 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
using Booking_Backend.Repository.Paging.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec0", @"/Views/ExtensionRoom/Index.cshtml")]
    #nullable restore
    public class Views_ExtensionRoom_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageResult<Booking_Backend.Repository.ExtensionRoom.ViewModel.ExtensionRoomViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 170px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "extensiontypeId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "extensionroom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"" style=""margin-bottom: 15px"">
        <div class=""col-md-11"">
            <div class=""block-add-hoteltype"" style=""border: thin solid #ccc; border-radius: 7px"">
                <div class=""row"">
                    <div class=""col-md-7 text-center"" style=""margin: auto 0"">
                        <h3");
            BeginWriteAttribute("class", " class=\"", 644, "\"", 652, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:0\">Quản lí các tiện ích dịch vụ</h3>\r\n\r\n                    </div>\r\n                    <div class=\"col-md-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec07292", async() => {
                WriteLiteral("\r\n                            <div class=\"row p-2 justify-content-end\">\r\n                                <div class=\"col-md-4 d-flex justify-content-end\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec07772", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec08104", async() => {
                        WriteLiteral("Tất cả");
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
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 24 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ExtensionTypes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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

    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-11"">
                <div class=""card mb-4"" style=""overflow-x: scroll; "">
                    <div class=""card-body"">
                        <table class=""table table-hover table-bordered"" style=""width: 100%"">
                            <thead>
                                <tr>
                                    <th>
                                        STT
                                    </th>
                                    <th>
                                        Id
                                    </th>
                                    <th>
                                        Tên
                                    </th>
                                    <th>
                                        Danh mục
                                    </th>
                   ");
            WriteLiteral(@"                 <th>
                                        Action
                                    </th>
                                </tr>
                            </thead>
                            <tfoot>
                                <tr>
                                    <th>
                                        STT
                                    </th>
                                    <th>
                                        Id
                                    </th>
                                    <th>
                                        Tên
                                    </th>
                                    <th>
                                        Danh mục
                                    </th>
                                    <th>
                                        Action
                                    </th>
                                </tr>
                            </tfoot>
                        ");
            WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 81 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                              
                                int count = 0;
                                foreach (var item in Model.Items)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87081ce2203317b2774facc096275c192f54c04de65570e9636903707eeaaec015227", async() => {
                WriteLiteral("\r\n                                                                            <tr class=\"data-viewer\">\r\n                                                                                <td class=\"text-nowrap\">\r\n                                            ");
#nullable restore
#line 89 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                    </td>\r\n                                                    <td class=\"text-nowrap\">\r\n                                                        <div>");
#nullable restore
#line 92 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                                                        Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4412, "\"", 4428, 1);
#nullable restore
#line 93 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
WriteAttributeValue("", 4420, item.Id, 4420, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                        <input type=\"hidden\" name=\"Language\"");
                BeginWriteAttribute("value", " value=\"", 4526, "\"", 4550, 1);
#nullable restore
#line 94 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
WriteAttributeValue("", 4534, item.LanguageId, 4534, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    </td>\r\n                                                    <td class=\"text-nowrap\">\r\n                                                        <div class=\"name-text\">");
#nullable restore
#line 97 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                        <input name=\"Name\" class=\"name-input form-control\" style=\"display: none\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 4960, "\"", 4978, 1);
#nullable restore
#line 98 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
WriteAttributeValue("", 4968, item.Name, 4968, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                    </td>\r\n                                                    <td class=\"text-nowrap\">\r\n                                                        <div class=\"name-text\">");
#nullable restore
#line 101 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.ExtensionTypeName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                                                    </td>
                                                    <td class=""text-nowrap"">
                                                        <a style=""text-decoration: none"" onclick=""setTimeout(()=> {location.reload()},1000)""");
                BeginWriteAttribute("href", " href=\"", 5538, "\"", 5604, 2);
                WriteAttributeValue("", 5545, "extensionroom/delete/", 5545, 21, true);
#nullable restore
#line 104 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
WriteAttributeValue("", 5566, Html.DisplayFor(modelItem => item.Id), 5566, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <div class=""btn btn-danger text-light"">Xóa</div>
                                                        </a>
                                                        <div class=""btn-update btn btn-warning text-light"">Cập nhật</div>
                                                        <div style=""display: none"" class=""btn-cancel btn btn-warning text-light"">Hủy</div>
                                                        <button type=""submit"" class=""btn-save btn btn-info text-light"" style=""display:none"">Lưu thay đổi</button>
                                                    </td>
                                                </tr>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 113 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 121 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\ExtensionRoom\Index.cshtml"
Write(await Component.InvokeAsync("Pager", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <script>
        document.addEventListener(""DOMContentLoaded"", function () {
            var updateButtons = document.querySelectorAll("".btn-update"");
            var cancelButtons = document.querySelectorAll("".btn-cancel"");

            updateButtons.forEach(function (button) {
                button.addEventListener(""click"", function () {
                    var row = button.parentNode.parentNode;
                    var nameText = row.querySelector("".name-text"");
                    var nameInput = row.querySelector("".name-input"");
                    var btnSave = row.querySelector("".btn-save"");
                    var btnUpdate = row.querySelector("".btn-update"");
                    var btnCancel = row.querySelector("".btn-cancel"");

                    // Hiện input và ẩn text
                    nameText.style.display = ""none"";
                    nameInput.style.display = ""inline"";
                    btnSave.style.display = ""inline"";
                    btnCancel.st");
            WriteLiteral(@"yle.display = ""inline"";
                    btnUpdate.style.display = ""none"";

                    // Focus vào input khi được hiện
                    nameInput.focus();
                });
            });

            cancelButtons.forEach(function (button) {
                button.addEventListener(""click"", function () {
                    var row = button.parentNode.parentNode;
                    var nameText = row.querySelector("".name-text"");
                    var nameInput = row.querySelector("".name-input"");
                    var btnSave = row.querySelector("".btn-save"");
                    var btnUpdate = row.querySelector("".btn-update"");
                    var btnCancel = row.querySelector("".btn-cancel"");

                    // Hiện input và ẩn text
                    nameText.style.display = ""inline"";
                    nameInput.style.display = ""none"";
                    btnSave.style.display = ""none"";
                    btnCancel.style.display = ""none"";
            ");
            WriteLiteral("        btnUpdate.style.display = \"inline\";\r\n\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n                    ");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageResult<Booking_Backend.Repository.ExtensionRoom.ViewModel.ExtensionRoomViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
