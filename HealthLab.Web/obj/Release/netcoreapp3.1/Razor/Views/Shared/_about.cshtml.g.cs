#pragma checksum "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244a40afdefb39024010558f093e6977abe57216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__about), @"mvc.1.0.view", @"/Views/Shared/_about.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244a40afdefb39024010558f093e6977abe57216", @"/Views/Shared/_about.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc9ccd0e0f826dac0a5447a3ed252bcd4b38125", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__about : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthLab.Framework.AboutLab.About>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div id=""about"" class=""about-box"">
    <div class=""about-a1"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""title-box"">
                        <h2>About Us</h2>
                        <p>About of Zamzam Hospital. </p>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
");
#nullable restore
#line 15 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml"
                     foreach (var about in ViewBag.About)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row align-items-center about-main-info\">\r\n                            <div class=\"col-lg-6 col-md-6 col-sm-12\">\r\n                                <h2> ");
#nullable restore
#line 19 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml"
                                Write(about.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                <p>");
#nullable restore
#line 20 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml"
                              Write(about.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
            WriteLiteral(@"                                <a href=""#"" class=""new-btn-d br-2"">Read More</a>
                            </div>
                            <div class=""col-lg-6 col-md-6 col-sm-12"">
                                <div class=""about-m"">
                                    <ul id=""banner"">
                                        <li>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "244a40afdefb39024010558f093e6977abe572165918", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1639, "~/about/", 1639, 8, true);
#nullable restore
#line 28 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml"
AddHtmlAttributeValue("", 1647, about.Image, 1647, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </li>\r\n\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 35 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_about.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthLab.Framework.AboutLab.About> Html { get; private set; }
    }
}
#pragma warning restore 1591