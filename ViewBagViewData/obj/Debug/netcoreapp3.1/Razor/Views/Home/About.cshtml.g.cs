#pragma checksum "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dfc0c83c2839c91bcfeb15c4046250edd3fc9b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\_ViewImports.cshtml"
using ViewBagViewData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dfc0c83c2839c91bcfeb15c4046250edd3fc9b3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4439683570380147900ad65d8b8b8dad332d09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>About</h1>\r\n\r\n<p>TempData=>");
#nullable restore
#line 8 "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\Home\About.cshtml"
        Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ViewData=>");
#nullable restore
#line 9 "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\Home\About.cshtml"
        Write(ViewData["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>ViewBag=>");
#nullable restore
#line 10 "C:\Users\ProBook\Desktop\BackEnd\ViewBagViewData\ViewBagViewData\Views\Home\About.cshtml"
       Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
