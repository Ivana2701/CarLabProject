#pragma checksum "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/ContactUsList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28862a1a4ef2148664c27c0559e292bfdfddd0319a7c0571b57479684e0a6710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminHome_ContactUsList), @"mvc.1.0.view", @"/Views/AdminHome/ContactUsList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"28862a1a4ef2148664c27c0559e292bfdfddd0319a7c0571b57479684e0a6710", @"/Views/AdminHome/ContactUsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4db59fb7263ea3949b5baea9a622d2b2e96063165d26c0096ced9c0b62ec9d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminHome_ContactUsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BGAuto.Models.CommonEntities.BasicDataModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_Breadcrumbs.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mg-b-20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("data-edit-common-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/ContactUsList.cshtml"
  
    ViewData["Title"] = "ContactUs List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-5 col-md-5\">\r\n        <!-- Breadcubs Area Start Here -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28862a1a4ef2148664c27c0559e292bfdfddd0319a7c0571b57479684e0a67106090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <!-- Breadcubs Area End Here -->
    </div>

  

</div>


<div class=""card height-auto"">
    <div class=""card-body"">
        <div class=""heading-layout1"">
            <div class=""item-title"">
                <h3>Contact Us List</h3>
            </div>
            <div class=""dropdown"">
            </div>
        </div>

        <div>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28862a1a4ef2148664c27c0559e292bfdfddd0319a7c0571b57479684e0a67107599", async() => {
                WriteLiteral(@"
                <div class=""row gutters-8"">
                    <div class=""col-3-xxxl col-xl-3 col-lg-3 col-12 form-group"">
                        <input type=""text"" placeholder=""Search by customer name ..."" id=""CustomerName"" class=""form-control"">
                    </div>

                    <div class=""col-3-xxxl col-xl-3 col-lg-3 col-12 form-group"">
                        <input type=""text"" placeholder=""Search by customer message ..."" id=""CustomerMessage"" class=""form-control"">
                    </div>




                    <div class=""col-1-xxxl col-xl-2 col-lg-3 col-12 form-group"">
                        <button type=""button"" onclick=""searchFilter();"" class=""fw-btn-fill btn-gradient-yellow"">SEARCH</button>
                    </div>


                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n        <!-- Grid listing starts here -->\r\n        <div class=\"table-responsive\" id=\"data_listing_grid\">\r\n            ");
#nullable restore
#line 57 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/ContactUsList.cshtml"
       Write(await Html.PartialAsync("~/Views/AdminHome/_ContactUsListtPartial.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <!-- Grid listing ends here -->

    </div>
</div>



<!-- edit status modal -->
<div class=""ui-modal-box"">
    <div class=""modal-box"">
        <div class=""modal sign-up-modal fade"" id=""edit_data_modal"" tabindex=""-1"" role=""dialog""
             aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-body"">
                        <div class=""close-btn"">
                            <button type=""button"" class=""close"" data-dismiss=""modal""
                                    aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""item-logo"">
                            <h3>Reply</h3>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28862a1a4ef2148664c27c0559e292bfdfddd0319a7c0571b57479684e0a671011291", async() => {
                WriteLiteral(@"
                            <div class=""row gutters-15"">
                                <div class=""form-group col-12"">
                                    <label for=""AdminReply"">Admin Reply</label>
                                  <textarea id=""AdminReply"" name=""AdminReply"" class=""form-control"" required></textarea>
                                    <input type=""hidden"" id=""ContactUsID"" name=""ContactUsID"">
                                </div>

                                <div class=""form-group col-12"">
                                    <button type=""button"" class=""login-btn"" onclick=""UpdateAdminReply();"">
                                        Update
                                    </button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

<script>


     $(document).ready(function() {
      createDataTable('table_listing_data', true);
    });


          function searchFilter() {

            let CustomerName = $(""#CustomerName"").val();
            let CustomerMessage=$(""#CustomerMessage"").val();
         

               let searchFormData = {
             CustomerName: CustomerName,
             CustomerMessage: CustomerMessage
        
         }

              var Url = '");
#nullable restore
#line 128 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/ContactUsList.cshtml"
                    Write(Url.Action("ContactUsList", "AdminHome"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

            $.ajax({
                type: ""GET"",
                url: Url,

                data: searchFormData,
                // datatype: ""json"",
                cache: false,
                async: false,

                success: function (data) {

                     destroyDataTable('table_listing_data');

                    $('#data_listing_grid').html(data);

                       createDataTable('table_listing_data', true);

                },
                error: function (xhr, ajaxOptions, thrownError) {
                      toastr.error('An error occured. Please try again!');

                }
            })
        }




        
    function showReplyModal(ContactUsID) {

          $('#ContactUsID').val(ContactUsID);

          $('#edit_data_modal').modal('show');

      }

       function UpdateAdminReply(){

              $(""#data-edit-common-form"").submit(function (e) {
                   e.preventDefault();
               });

     ");
                WriteLiteral(@"          if (!$(""#data-edit-common-form"").valid()) {
                    event.preventDefault();
                   return false;
               }
               
 

               let AdminReply = $(""#AdminReply"").val();
               let ContactUsID=$(""#ContactUsID"").val();
             
               if(!checkIfStringIsEmtpy(AdminReply) || !checkIfStringIsEmtpy(ContactUsID)){
                   toastr.error('Please fill all required fields.');
                   return false;
               }


                //--make form data
                var formDate = {
                    AdminReply: AdminReply,
                    ContactUsID: ContactUsID,
                 
                }

                let saveUrl = """);
#nullable restore
#line 196 "/Users/ibazhdarova/Downloads/BG-AutoProject 2/BGAuto/BGAuto/Views/AdminHome/ContactUsList.cshtml"
                          Write(Url.Action("UpdateAdminReply", "AdminHome"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                 $.ajax({
                       type: ""POST"",
                       url: saveUrl,
                       data: formDate,
                       // datatype: ""json"",
                       cache: false,
                       async: false,

                       success: function (data) {
                            console.log(data);
                            if (data.success) {
                            toastr.success('Saved Successfully!');
                            setTimeout(function () {
                                $('#search-form').trigger(""reset"");
                                $('#data-edit-common-form').trigger(""reset"");
                                $('#edit_data_modal').modal('hide');
                                searchFilter();
                            }, 500);
                            } else {

                            toastr.error(data.message);
                            }

                       },
                      ");
                WriteLiteral(" error: function (xhr, ajaxOptions, thrownError) {\r\n                         toastr.error(\'An error occured. Please try again!\');\r\n                       }\r\n                   })\r\n\r\n        }\r\n\r\n\r\n</script>\r\n");
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
