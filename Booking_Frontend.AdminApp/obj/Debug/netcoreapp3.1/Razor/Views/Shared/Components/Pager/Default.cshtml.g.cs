#pragma checksum "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "acc7f31516aca69c97f23acda5c0ef3d13b95e5d6ef8c4635f5b5104ae66c300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"acc7f31516aca69c97f23acda5c0ef3d13b95e5d6ef8c4635f5b5104ae66c300", @"/Views/Shared/Components/Pager/Default.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking_Backend.Repository.Paging.ViewModel.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageindex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageindex")
        {
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }
    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination pagination-sm\">\r\n");
#nullable restore
#line 29 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 947, "\"", 1013, 1);
#nullable restore
#line 31 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 954, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 954, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a></li>\r\n");
#nullable restore
#line 32 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\"><a class=\"page-link\" href=\"#\">");
#nullable restore
#line 38 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 39 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1364, "\"", 1391, 2);
            WriteAttributeValue("", 1372, "Trang", 1372, 5, true);
#nullable restore
#line 42 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1377, i.ToString(), 1378, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1392, "\"", 1440, 1);
#nullable restore
#line 42 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1399, urlTemplate.Replace("{0}", i.ToString()), 1399, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 43 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1592, "\"", 1658, 1);
#nullable restore
#line 47 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1599, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1599, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a></li>\r\n");
#nullable restore
#line 48 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 51 "Z:\GRADUATE\BackEnd\Booking_Backend\Booking_Frontend.AdminApp\Views\Shared\Components\Pager\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking_Backend.Repository.Paging.ViewModel.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
