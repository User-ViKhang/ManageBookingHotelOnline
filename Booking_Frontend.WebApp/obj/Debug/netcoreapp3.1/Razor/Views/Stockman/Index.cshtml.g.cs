#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "893a3e93cbf3aacbd593e2e6dfb01bc76271c71806b80a423e9ed0b92ae3b32d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stockman_Index), @"mvc.1.0.view", @"/Views/Stockman/Index.cshtml")]
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
#line 1 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
using Booking_Frontend.WebApp.Models.Owner;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"893a3e93cbf3aacbd593e2e6dfb01bc76271c71806b80a423e9ed0b92ae3b32d", @"/Views/Stockman/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4b599e0366a677a8ea3b9eec10ab2dceb089884055e7760cbfe0a588b4990470", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Stockman_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotifyBookingViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/stockman/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
  
    ViewData["Title"] = "Trang chi tiết";
    Layout = "_LayoutOwner";

#line default
#line hidden
#nullable disable
            DefineSection("IndexStyle", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "893a3e93cbf3aacbd593e2e6dfb01bc76271c71806b80a423e9ed0b92ae3b32d4613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<style>
    .add-picture {
        position: relative;
    }

    .add-picture::before {
        content: ""Tải ảnh"";
        position: absolute;
        background-color: white;
        padding: 0 5px;
        top: -15%;
        left: 5px;
    }
</style>
<div id=""layoutSidenav_content"">
    <div class=""container mt-3"">
        <div class=""wrapper-thumbnail"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <div class=""card-template"" style=""box-shadow:0 0 3px 1px #ccc; height: 280px; width: 200px;border: thin solid #ccc; border-radius: 10px; overflow: hidden"">
                        <div class=""card-img"" style=""width: 100%; height: 180px;"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 1067, "\"", 1136, 1);
#nullable restore
#line 34 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
WriteAttributeValue("", 1073, Configuration["HostServer"] + Model.HotelViewModel.Thumbnail, 1073, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 200px; height: 200px; object-fit: cover"" />
                            <div class=""mt-2"" style=""width: 90%; height: 15px; background-color: #ccc""></div>
                            <div class=""mt-2"" style=""width: 40%; height: 15px; background-color: #ccc""></div>
                            <div class=""mt-2"" style=""width: 20%; margin-left:140px; height: 15px; background-color: #ccc""></div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""card-location"" style=""width: 100%; border: thin solid #ccc; height: 200px; box-shadow: 0 0 3px 1px #ccc; border-radius: 15px"">
                        <div class=""row"">
                            <div class=""col-md-4"">
                                <div class=""section-img"" style=""height: 200px; overflow: hidden"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 2067, "\"", 2136, 1);
#nullable restore
#line 46 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
WriteAttributeValue("", 2073, Configuration["HostServer"] + Model.HotelViewModel.Thumbnail, 2073, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 200px; object-fit: cover; height: 200px; border-top-left-radius: 15px; border-bottom-left-radius: 15px"" />
                                </div>
                            </div>
                            <div class=""col-md-8"">
                                <div class=""mt-2"" style=""width: 90%; height: 15px; background-color: #ccc""></div>
                                <div class=""mt-2"" style=""width: 50%; height: 15px; background-color: #ccc""></div>
                                <hr />
                                <div class=""mt-2"" style=""width: 90%; height: 100px; background-color: #ccc""></div>

                            </div>
                        </div>
                    </div>
                    <div class=""mt-3"">
                        <form method=""post"" action=""/store-picture/update-thumbnail"" enctype=""multipart/form-data"">
                            <input name=""Image"" type=""file"" id=""file-upload"" accept=""image/*"" required>
                           ");
            WriteLiteral(@" <div class=""mt-2"">
                                <button type=""submit"" class=""btn btn-primary"">Tải ảnh lên</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
            <hr />
            <div class=""row"">
");
#nullable restore
#line 70 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
                 foreach (var item in Model.Images)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-2\">\r\n                        <div class=\"mb-3\" style=\"width: 100%;position:relative \">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3705, "\"", 3757, 1);
#nullable restore
#line 74 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
WriteAttributeValue("", 3711, Configuration["HostServer"] + item.ImageUrl, 3711, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 100%; height: 150px"" />
                            <div class="" btn-delete d-flex align-items-center justify-content-center"" style=""width:20px; height:20px; background-color: white; position:absolute; bottom:0;"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 4023, "\"", 4050, 2);
            WriteAttributeValue("", 4030, "/delete-img/", 4030, 12, true);
#nullable restore
#line 76 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
WriteAttributeValue("", 4042, item.Id, 4042, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 20px; text-decoration:none; color: red\">x</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>       \r\n");
#nullable restore
#line 80 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <form method=\"post\"");
            BeginWriteAttribute("action", " action=\"", 4290, "\"", 4351, 2);
            WriteAttributeValue("", 4299, "/store-picture/update-image/", 4299, 28, true);
#nullable restore
#line 82 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.WebApp\Views\Stockman\Index.cshtml"
WriteAttributeValue("", 4327, Model.HotelViewModel.Id, 4327, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" enctype=""multipart/form-data"">
                <div class=""add-picture"" style=""width: 400px; height: 100px; border: thin solid #ccc; padding:20px"">
                        <input type=""file"" name=""Image""/>
                    <div class=""mt-1""><button class=""btn btn-primary"">Tải ảnh</button></div>
                </div>    
             </form>
        </div>
    </div>
</div>
<script>
    const fileUpload = document.getElementById('file-upload');
    const fileLabel = document.getElementById('file-label');
    const fileName = document.getElementById('file-name');

    fileUpload.addEventListener('change', (event) => {
        const file = event.target.files[0];
        const fileNameText = `Selected file: ${file.name}`;
        fileName.textContent = fileNameText;
        fileLabel.innerHTML = `<span>${file.name}</span>`;
    });
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
