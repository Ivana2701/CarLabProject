#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_Breadcrumbs.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6bf942fc547da447dd16846a1b8b6f9c087f3df22548cb1abc035c20d8610929"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Breadcrumbs), @"mvc.1.0.view", @"/Views/Shared/_Breadcrumbs.cshtml")]
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
#line 1 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/_ViewImports.cshtml"
using BGAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/_ViewImports.cshtml"
using BGAuto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/_ViewImports.cshtml"
using BGAuto.DAL.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6bf942fc547da447dd16846a1b8b6f9c087f3df22548cb1abc035c20d8610929", @"/Views/Shared/_Breadcrumbs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Breadcrumbs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"breadcrumbs-area\">\r\n");
#nullable restore
#line 4 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_Breadcrumbs.cshtml"
      
        string BreadCrumTitle = String.IsNullOrWhiteSpace(ViewBag.BreadCrumTitle) ? "Main" : ViewBag.BreadCrumTitle;
        string BreadCrumSubTitle = String.IsNullOrWhiteSpace(ViewBag.BreadCrumSubTitle) ? "List" : ViewBag.BreadCrumSubTitle;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>\r\n            <a href=\"#\">");
#nullable restore
#line 10 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_Breadcrumbs.cshtml"
                   Write(BreadCrumTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        </li>\r\n        <li>");
#nullable restore
#line 12 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_Breadcrumbs.cshtml"
       Write(BreadCrumSubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICustomerURLHelper urlHelper { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor sessonContext { get; private set; } = default!;
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
