#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "064fe209290fd8dcff8acea14d6d01013725067fb9d513e9d95a73a5ca2d961b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BasicData__ModelsPartial), @"mvc.1.0.view", @"/Views/BasicData/_ModelsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"064fe209290fd8dcff8acea14d6d01013725067fb9d513e9d95a73a5ca2d961b", @"/Views/BasicData/_ModelsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BasicData__ModelsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BGAuto.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table display text-nowrap"" id=""table_listing_data"">
    <thead>
        <tr>

            <th class=""no-sort""> ID</th>
            <th class=""no-sort""> Model Name</th>
            <th class=""no-sort""> Make</th>
            <th class=""no-sort"">CreatedOn</th>
         
         
            <th class=""no-sort"">Action</th>
        </tr>
    </thead>
    <tbody>


");
#nullable restore
#line 19 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
          
            if (Model != null && Model.ModelsList != null && Model.ModelsList.Count > 0)
            {
                foreach (var item in Model.ModelsList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 26 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
                       Write(item.ModelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
                       Write(item.ModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
                       Write(item.MakeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
                       Write(item.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                     
                     
                    
                        <td>
                            <div class=""dropdown"">
                                <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" aria-expanded=""false"">
                                    <span class=""flaticon-more-button-of-three-dots""></span>
                                </a>
                                <div class=""dropdown-menu dropdown-menu-right"">

                                    <a class=""dropdown-item"" href=""#!""");
            BeginWriteAttribute("onclick", "  onclick=\"", 1414, "\"", 1492, 9);
            WriteAttributeValue("", 1425, "showEditModal(\'", 1425, 15, true);
#nullable restore
#line 40 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
WriteAttributeValue("", 1440, item.ModelID, 1440, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1453, "\',", 1453, 2, true);
            WriteAttributeValue("  ", 1455, "\'", 1457, 3, true);
#nullable restore
#line 40 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
WriteAttributeValue("", 1458, item.MakeID, 1458, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1470, "\',", 1470, 2, true);
            WriteAttributeValue(" ", 1472, "\'", 1473, 2, true);
#nullable restore
#line 40 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
WriteAttributeValue("", 1474, item.ModelName, 1474, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1489, "\');", 1489, 3, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-cogs text-dark-pastel-green\"></i>Edit</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1614, "\"", 1678, 5);
            WriteAttributeValue("", 1624, "showDeleteModal(\'", 1624, 17, true);
#nullable restore
#line 41 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"
WriteAttributeValue("", 1641, item.ModelID, 1641, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1654, "\',", 1654, 2, true);
            WriteAttributeValue(" ", 1656, "\'ModelID\',", 1657, 11, true);
            WriteAttributeValue(" ", 1667, "\'Models\');", 1668, 11, true);
            EndWriteAttribute();
            WriteLiteral(" href=\"#!\"><i class=\"fas fa-times text-orange-red\"></i>Delete</a>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/BasicData/_ModelsPartial.cshtml"

                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
