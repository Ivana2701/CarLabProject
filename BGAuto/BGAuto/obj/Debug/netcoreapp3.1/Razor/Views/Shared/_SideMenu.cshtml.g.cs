#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a5f8d09d088a01032fe9c85bcd8584fe1adc7201d6e366cd0695d95e333dd610"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SideMenu), @"mvc.1.0.view", @"/Views/Shared/_SideMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a5f8d09d088a01032fe9c85bcd8584fe1adc7201d6e366cd0695d95e333dd610", @"/Views/Shared/_SideMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SideMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/admin/img/logo1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"sidebar-main sidebar-menu-one sidebar-expand-md sidebar-color\">\r\n    <div class=\"mobile-sidebar-header d-md-none\">\r\n        <div class=\"header-logo\">\r\n            <a href=\"index.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a5f8d09d088a01032fe9c85bcd8584fe1adc7201d6e366cd0695d95e333dd6104555", async() => {
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
            WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n    <div class=\"sidebar-menu-content\">\r\n        <ul class=\"nav nav-sidebar-menu sidebar-toggle-view\">\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 449, "\"", 488, 1);
#nullable restore
#line 13 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 456, Url.Action("Index","AdminHome"), 456, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                    <i class=\"flaticon-dashboard\"></i><span>Dashboard</span>\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 733, 1);
#nullable restore
#line 19 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 690, Url.Action("ProductsList","AdminProducts"), 690, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                    <i class=\"flaticon-shopping-list\"></i><span>Cars</span>\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 927, "\"", 975, 1);
#nullable restore
#line 25 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 934, Url.Action("OrdersList","AdminProducts"), 934, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                    <i class=\"flaticon-technological\"></i><span>Orders</span>\r\n                </a>\r\n            </li>\r\n\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1171, "\"", 1218, 1);
#nullable restore
#line 31 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 1178, Url.Action("ContactUsList","AdminHome"), 1178, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">
                    <i class=""flaticon-chat""></i><span>Contact Us</span>
                </a>
            </li>

            <li class=""nav-item sidebar-nav-item"">
                <a href=""#"" class=""nav-link"">
                    <i class=""flaticon-menu-1""></i><span>Basic Data</span>
                </a>
                <ul class=""nav sub-group-menu"">
                    <li class=""nav-item"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1671, "\"", 1710, 1);
#nullable restore
#line 42 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 1678, Url.Action("Makes","BasicData"), 1678, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                            <i class=\"fas fa-angle-right\"></i>Makes (Brands)\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 1975, 1);
#nullable restore
#line 47 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 1942, Url.Action("Models","BasicData"), 1942, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                            <i class=\"fas fa-angle-right\"></i>Models\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2192, "\"", 2232, 1);
#nullable restore
#line 52 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_SideMenu.cshtml"
WriteAttributeValue("", 2199, Url.Action("Colors","BasicData"), 2199, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">\r\n                            <i class=\"fas fa-angle-right\"></i>Colors\r\n\r\n                        </a>\r\n                    </li>\r\n\r\n                </ul>\r\n            </li>\r\n\r\n        </ul>\r\n    </div>\r\n</div>");
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
