#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4ef3cb1694353c456788992406c45f6dae65224f11263b2a72543aaf56d53247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome_Index), @"mvc.1.0.view", @"/Views/AdminHome/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4ef3cb1694353c456788992406c45f6dae65224f11263b2a72543aaf56d53247", @"/Views/AdminHome/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminHome_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BGAuto.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
  
    ViewData["Title"] = "Faculty";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
  
    int TotalProducts = 0; ;
    int TotalOrders = 0;
    int TotalCustomerQueries = 0;
    int TotalCategories = 0;
    int TotalMakes = 0;
    int TotalModels = 0;


    if (Model != null && Model.DashboardDataObj != null)
    {
        TotalProducts = Model.DashboardDataObj.TotalProducts;
        TotalOrders = Model.DashboardDataObj.TotalOrders;
        TotalCustomerQueries = Model.DashboardDataObj.TotalCustomerQueries;
        TotalCategories = Model.DashboardDataObj.TotalCategories;
        TotalMakes = Model.DashboardDataObj.TotalMakes;
        TotalModels = Model.DashboardDataObj.TotalModels;

    }

    int activeOrders = 0;
    int inprogressOrdes = 0;
    int completedOrders = 0;
    if (Model != null && Model.DashboardDataOrderStatusList != null && Model.DashboardDataOrderStatusList.Count > 0)
    {
        try
        {
            activeOrders = (int)Model.DashboardDataOrderStatusList.Where(s => s.StatusID == 1 || s.StatusName == "Active").FirstOrDefault().StatusID;
            inprogressOrdes = (int)Model.DashboardDataOrderStatusList.Where(s => s.StatusID == 2 || s.StatusName == "In Progress").FirstOrDefault().StatusID;
            completedOrders = (int)Model.DashboardDataOrderStatusList.Where(s => s.StatusID == 3 || s.StatusName == "Completed").FirstOrDefault().StatusID;
        }
        catch
        {

        }


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5 col-md-5\">\r\n        <!-- Breadcubs Area Start Here -->\r\n        <div class=\"breadcrumbs-area\">\r\n");
#nullable restore
#line 51 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
              
                string BreadCrumTitle = String.IsNullOrWhiteSpace(ViewBag.BreadCrumTitle) ? "Main" : ViewBag.BreadCrumTitle;
                string BreadCrumSubTitle = String.IsNullOrWhiteSpace(ViewBag.BreadCrumSubTitle) ? "List" : ViewBag.BreadCrumSubTitle;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>Admin Dashboard</h3>\r\n            <ul>\r\n                <li>\r\n                    <a href=\"#\">");
#nullable restore
#line 58 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                           Write(BreadCrumTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </li>\r\n                <li>");
#nullable restore
#line 60 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
               Write(BreadCrumSubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ul>
        </div>
        <!-- Breadcubs Area End Here -->
    </div>



</div>


<!-- Dashboard summery Start Here -->
<div class=""row gutters-20"">
    <div class=""col-xl-3 col-sm-6 col-12"">
        <div class=""dashboard-summery-one mg-b-20"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""item-icon bg-light-green "">
                        <i class=""flaticon-shopping-list text-green""></i>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""item-content"">
                        <div class=""item-title"">Total Orders</div>
                        <div class=""item-number""><span class=""counter"" data-num=""");
#nullable restore
#line 84 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                            Write(TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 84 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                                          Write(TotalOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 col-12"">
        <div class=""dashboard-summery-one mg-b-20"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""item-icon bg-light-blue"">
                        <i class=""flaticon-magnifying-glass text-blue""></i>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""item-content"">
                        <div class=""item-title"">Total Cars</div>
                        <div class=""item-number""><span class=""counter"" data-num=""");
#nullable restore
#line 101 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                            Write(TotalProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 101 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                                            Write(TotalProducts);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 col-12"">
        <div class=""dashboard-summery-one mg-b-20"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""item-icon bg-light-yellow"">
                        <i class=""flaticon-couple text-orange""></i>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""item-content"">
                        <div class=""item-title"">Customer Queries</div>
                        <div class=""item-number""><span class=""counter"" data-num=""");
#nullable restore
#line 118 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                            Write(TotalCustomerQueries);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 118 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                                                   Write(TotalCustomerQueries);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 col-12"">
        <div class=""dashboard-summery-one mg-b-20"">
            <div class=""row align-items-center"">
                <div class=""col-6"">
                    <div class=""item-icon bg-light-red"">
                        <i class=""flaticon-money text-red""></i>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""item-content"">
                        <div class=""item-title"">Total Makes</div>
                        <div class=""item-number""><span class=""counter"" data-num=""");
#nullable restore
#line 135 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                            Write(TotalMakes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 135 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                                                                                         Write(TotalMakes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</div>

<div class=""row gutters-20"">
    <div class=""col-lg-12 col-xl-12"">
        <div class=""card dashboard-card-six pd-b-20"">
            <div class=""card-body"">
                <div class=""heading-layout1 mg-b-17"">
                    <div class=""item-title"">
                        <h3>Order Statuses</h3>
                    </div>
                    <div class=""dropdown"">
                    </div>
                </div>
                <div class=""notice-box-wrap"">
                    <div class=""notice-list"">
                        <div class=""post-date bg-skyblue"">Active</div>
                        <h6 class=""notice-title"">
                            <a href=""#"">
                                ");
#nullable restore
#line 161 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                           Write(activeOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </h6>


                    </div>
                    <div class=""notice-list"">
                        <div class=""post-date bg-yellow"">In Progress</div>
                        <h6 class=""notice-title"">
                            <a href=""#"">
                                ");
#nullable restore
#line 171 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                           Write(inprogressOrdes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </h6>

                    </div>
                    <div class=""notice-list"">
                        <div class=""post-date bg-pink"">Completed</div>
                        <h6 class=""notice-title"">
                            <a href=""#"">
                                ");
#nullable restore
#line 180 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/Index.cshtml"
                           Write(completedOrders);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h6>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<!-- Dashboard summery End Here -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BGAuto.Models.CommonEntities.BasicDataModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591