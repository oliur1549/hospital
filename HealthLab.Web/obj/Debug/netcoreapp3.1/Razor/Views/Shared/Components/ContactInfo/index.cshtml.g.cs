#pragma checksum "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24620dbaa28035f737d5afe8b6a6871e1194c8be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ContactInfo_index), @"mvc.1.0.view", @"/Views/Shared/Components/ContactInfo/index.cshtml")]
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
#line 1 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\_ViewImports.cshtml"
using HealthLab.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\_ViewImports.cshtml"
using HealthLab.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\_ViewImports.cshtml"
using HealthLab.Framework.ServiceLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\_ViewImports.cshtml"
using HealthLab.Web.Models.Appointments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\_ViewImports.cshtml"
using HealthLab.Framework.AddressLab;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24620dbaa28035f737d5afe8b6a6871e1194c8be", @"/Views/Shared/Components/ContactInfo/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc9ccd0e0f826dac0a5447a3ed252bcd4b38125", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ContactInfo_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container text-center text-md-left mt-5\">\r\n\r\n    <!-- Grid row -->\r\n    <div class=\"row mt-3\">\r\n");
#nullable restore
#line 6 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Grid column -->
        <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">

            <!-- Content -->
            <h6 class=""text-uppercase font-weight-bold"">Company name</h6>
            <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
            <p>
                ");
#nullable restore
#line 15 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            \r\n        </div>\r\n        <!-- Grid column -->\r\n        <!-- Grid column -->\r\n");
            WriteLiteral(@"        <!-- Grid column -->
        <!-- Grid column -->
        <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">

            <!-- Links -->
            <h6 class=""text-uppercase font-weight-bold"">Useful links</h6>
            <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
            <p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24620dbaa28035f737d5afe8b6a6871e1194c8be6426", async() => {
                WriteLiteral("Appointment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24620dbaa28035f737d5afe8b6a6871e1194c8be7847", async() => {
                WriteLiteral("Contact");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24620dbaa28035f737d5afe8b6a6871e1194c8be9264", async() => {
                WriteLiteral("About");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24620dbaa28035f737d5afe8b6a6871e1194c8be10679", async() => {
                WriteLiteral("Help");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </p>

        </div>
        <!-- Grid column -->
        <!-- Grid column -->
        <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">

            <!-- Links -->
            <h6 class=""text-uppercase font-weight-bold"">Contact</h6>
            <hr class=""deep-purple accent-2 mb-4 mt-0 d-inline-block mx-auto"" style=""width: 60px;"">
            <p>
                <i class=""fas fa-home mr-3""></i> ");
#nullable restore
#line 51 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
                                            Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                <i class=\"fas fa-envelope mr-3\"></i> ");
#nullable restore
#line 54 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
                                                Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <p>\r\n                <i class=\"fas fa-phone mr-3\"></i> ");
#nullable restore
#line 57 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
                                             Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n");
            WriteLiteral("\r\n        </div>\r\n        <!-- Grid column -->\r\n");
#nullable restore
#line 65 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\Components\ContactInfo\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <!-- Grid row -->\r\n\r\n</div>\r\n<!-- Footer Links -->\r\n<!-- Copyright -->\r\n<div class=\"footer-copyright text-center py-3\">\r\n    © 2020 Copyright:\r\n    <a href=\"https://mdbootstrap.com/\"> MDBootstrap.com</a>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
