#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d455f3560cd2cdd0d92b003cb0b9592ee43d28e3437c71fe2cc3f13afa34c3ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderCustomer), @"mvc.1.0.view", @"/Views/Shared/_HeaderCustomer.cshtml")]
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
#nullable restore
#line 1 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
using BGAuto.Models.DbEntities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d455f3560cd2cdd0d92b003cb0b9592ee43d28e3437c71fe2cc3f13afa34c3ca", @"/Views/Shared/_HeaderCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__HeaderCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/customer/demos/car/images/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Canvas Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/themeContent/customer/demos/car/images/logo@2x.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
  
    List<Products> userProducts = new List<Products>();
    var UserCart = sessonContext.HttpContext.Session.GetString("UserCart");
    if (!String.IsNullOrEmpty(UserCart))
    {
        userProducts = JsonConvert.DeserializeObject<List<Products>>(UserCart);
    }

    int TotalItems = userProducts == null || userProducts.Count < 1 ? 0 : userProducts.Count;


    string baseURL = urlHelper.GetSiteBaseURL();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
  
    Users CustomerUser = new Users();

    var CustomerUserJson = sessonContext.HttpContext.Session.GetString("CustomerUser");
    if (!String.IsNullOrEmpty(CustomerUserJson))
    {
        CustomerUser = JsonConvert.DeserializeObject<Users>(CustomerUserJson);
    }

    CustomerUser = CustomerUser == null || CustomerUser.UserID < 1 ? new Users() : CustomerUser;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header id=""header"" class=""full-header header-size-custom"" data-sticky-shrink=""false"">
            <div id=""header-wrap"">
                <div class=""container-fluid"">
                    <div class=""header-row flex-lg-row-reverse"">

                        <!-- Logo
                        ============================================= -->
                        <div id=""logo"" class=""me-lg-0 ms-lg-auto"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1326, "\"", 1368, 1);
#nullable restore
#line 41 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 1333, Url.Action("Index","CustomerHome"), 1333, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"standard-logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d455f3560cd2cdd0d92b003cb0b9592ee43d28e3437c71fe2cc3f13afa34c3ca7273", async() => {
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
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1507, "\"", 1549, 1);
#nullable restore
#line 42 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 1514, Url.Action("Index","CustomerHome"), 1514, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"retina-logo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d455f3560cd2cdd0d92b003cb0b9592ee43d28e3437c71fe2cc3f13afa34c3ca8845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div><!-- #logo end -->

                        <div id=""primary-menu-trigger"">
                            <svg class=""svg-trigger"" viewBox=""0 0 100 100""><path d=""m 30,33 h 40 c 3.722839,0 7.5,3.126468 7.5,8.578427 0,5.451959 -2.727029,8.421573 -7.5,8.421573 h -20""></path><path d=""m 30,50 h 40""></path><path d=""m 70,67 h -40 c 0,0 -7.5,-0.802118 -7.5,-8.365747 0,-7.563629 7.5,-8.634253 7.5,-8.634253 h 20""></path></svg>
                        </div>

                        <!-- Primary Navigation
                        ============================================= -->
                        <nav class=""primary-menu with-arrows"">
                            <ul class=""menu-container"">
                                <li class=""menu-item current""><a class=""menu-link""");
            BeginWriteAttribute("href", " href=\"", 2473, "\"", 2515, 1);
#nullable restore
#line 53 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 2480, Url.Action("Index","CustomerHome"), 2480, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Home</div></a></li>\r\n\r\n\r\n\r\n                                    <li class=\"menu-item\"><a class=\"menu-link\" href=\"#\"><div>Account</div></a>\r\n                                    <ul class=\"sub-menu-container\">\r\n\r\n");
#nullable restore
#line 60 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
                                  
                                    if (CustomerUser != null && CustomerUser.UserID > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 2983, "\"", 3044, 1);
#nullable restore
#line 63 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 2990, Url.Action("LogoutCustomer","CustomerAuthentication"), 2990, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Logout</div></a></li>\r\n");
#nullable restore
#line 64 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                           <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 3279, "\"", 3346, 1);
#nullable restore
#line 67 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 3286, Url.Action("LoginRegisterAccount","CustomerAuthentication"), 3286, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Login</div></a></li>\r\n");
#nullable restore
#line 68 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
                                    }

                                    if (CustomerUser != null && CustomerUser.UserID > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 3626, "\"", 3725, 1);
#nullable restore
#line 72 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 3633, Url.Action("CarsCustomerBookingList","CustomerHome" , new {CustomerID=CustomerUser.UserID}), 3633, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Bookings</div></a></li>\n");
#nullable restore
#line 73 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                     \r\n                                    </ul>\r\n                                </li>\r\n\r\n\r\n                                <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 4033, "\"", 4078, 1);
#nullable restore
#line 82 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 4040, Url.Action("CarsList","CustomerHome"), 4040, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Car Listing</div></a></li>\r\n                                <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 4187, "\"", 4231, 1);
#nullable restore
#line 83 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 4194, Url.Action("AboutUs","CustomerHome"), 4194, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>About Us</div></a></li>\r\n\r\n                                <li class=\"menu-item\"><a class=\"menu-link\"");
            BeginWriteAttribute("href", " href=\"", 4339, "\"", 4385, 1);
#nullable restore
#line 85 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 4346, Url.Action("ContactUs","CustomerHome"), 4346, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><div>Contacts Us</div></a></li>\r\n\r\n                                  <li class=\"menu-item\">\r\n\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4514, "\"", 4560, 1);
#nullable restore
#line 90 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
WriteAttributeValue("", 4521, Url.Action("CartItems","CustomerHome"), 4521, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div id=\"top-cart\" class=\"header-misc-icon d-none d-sm-block top-cart-open\">\r\n                                    <i class=\"icon-line-bag\"></i>\r\n                                    <span class=\"top-cart-number\">");
#nullable restore
#line 93 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/Shared/_HeaderCustomer.cshtml"
                                                             Write(TotalItems);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>



                                </div>

                            </a>
                          </li>

                            </ul>
                        </nav><!-- #primary-menu end -->

                    </div>
                </div>
            </div>
            <div class=""header-wrap-clone""></div>
        </header>");
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