#pragma checksum "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_slide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7793a0c0474e842ad15a46d73bdd46f5b41a7a35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__slide), @"mvc.1.0.view", @"/Views/Shared/_slide.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7793a0c0474e842ad15a46d73bdd46f5b41a7a35", @"/Views/Shared/_slide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc9ccd0e0f826dac0a5447a3ed252bcd4b38125", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__slide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Start Banner -->\r\n<div class=\"ulockd-home-slider\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"pogoSlider\" id=\"js-main-slider\">\r\n\r\n");
#nullable restore
#line 7 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_slide.cshtml"
                 foreach (var item in ViewBag.SlideShow)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pogoSlider-slide\" data-transition=\"fade\">\r\n                        <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7793a0c0474e842ad15a46d73bdd46f5b41a7a354568", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 398, "~/slideshow/", 398, 12, true);
#nullable restore
#line 11 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_slide.cshtml"
AddHtmlAttributeValue("", 410, item.Name, 410, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        <div class=\"lbox-caption pogoSlider-slide-element\">\r\n                            <div class=\"lbox-details\">\r\n");
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 20 "E:\My Projects\HealthLab.Web\HealthLab.Web\Views\Shared\_slide.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div><!-- .pogoSlider -->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("<!-- End Banner -->");
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
