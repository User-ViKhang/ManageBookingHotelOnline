#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bda383e7bdf0cf485416b2aa61c615ff4a97fbef9a66974c6c932d11dc7bfc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
using Booking_Backend.Repository.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
using Booking_Backend.Repository.Paging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
using Booking_Backend.Repository.Paging.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
using Booking_Backend.Repository.Users.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
using Booking_Frontend.AdminApp.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bda383e7bdf0cf485416b2aa61c615ff4a97fbef9a66974c6c932d11dc7bfc28", @"/Views/User/Index.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<APIResult_Success<PageResult<UserViewModel>>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card mb-4\" style=\"overflow-x: scroll; \">\r\n    <div class=\"card-body\">\r\n        <h4>Danh sách tất cả người dùng: ");
#nullable restore
#line 17 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                                    Write(Model.ResultOject.TotalRecord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <table class=\"table table-hover table-bordered\" style=\"width: 100%\"");
            BeginWriteAttribute("id", " id=\"", 671, "\"", 676, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead>
                <tr>
                    <th>
                        STT
                    </th>
                    <th>
                        Id
                    </th>
                    <th>
                        UserName
                    </th>
                    <th>
                        Avatar
                    </th>
                    <th>
                        Email
                    </th>
                    <th>
                        PhoneNumber
                    </th>
                    <th>
                        FirstName
                    </th>
                    <th>
                        LastName
                    </th>
                    <th>
                        DisplayName
                    </th>
                    <th>
                        Birthday
                    </th>
                    <th>
                        Nation
                    </th>
                    <th>
      ");
            WriteLiteral(@"                  Gender
                    </th>
                    <th>
                        Address
                    </th>
                    <th>
                        Dasboard
                    </th>
                    <th>
                        CreatedAt
                    </th>
                    <th>
                        Status
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
                        UserName
                    </th>
                    <th>
                        Avatar
                    </th>
                    <th>
                        Email
                    </th>
                    <th>
                        PhoneNumber
                    </th>
                    <th>
 ");
            WriteLiteral(@"                       FirstName
                    </th>
                    <th>
                        LastName
                    </th>
                    <th>
                        DisplayName
                    </th>
                    <th>
                        Birthday
                    </th>
                    <th>
                        Nation
                    </th>
                    <th>
                        Gender
                    </th>
                    <th>
                        Address
                    </th>
                    <th>
                        Dasboard
                    </th>
                    <th>
                        CreatedAt
                    </th>
                    <th>
                        Status
                    </th>
                </tr>
            </tfoot>
            <tbody>
");
#nullable restore
#line 124 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                  
                    int count = 0;
                    foreach (var item in Model.ResultOject.Items)
                    {
                        count += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr data-href=\"user/update/");
#nullable restore
#line 129 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"data-viewer\">\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 131 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 134 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 137 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 140 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.AvatarUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 143 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 146 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 149 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 152 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 155 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 158 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 161 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Nation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 164 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 167 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 170 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Dashboard));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 173 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-nowrap\">\r\n                                ");
#nullable restore
#line 176 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 179 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table> \r\n        ");
#nullable restore
#line 183 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\User\Index.cshtml"
   Write(await Component.InvokeAsync("Pager", Model.ResultOject));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </div>
    </div>
<script>
    document.addEventListener(""DOMContentLoaded"", () => {
        const rows = document.querySelectorAll(""tr[data-href]"")
        rows.forEach((row) => {
            row.addEventListener(""click"", () => {
                window.location.href = row.dataset.href
            });
        });
    });
</script>










");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APIResult_Success<PageResult<UserViewModel>>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
