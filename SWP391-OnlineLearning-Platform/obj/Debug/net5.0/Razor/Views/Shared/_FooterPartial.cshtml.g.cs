#pragma checksum "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\Merge\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da8d11c521cf75e4ba8e0892b18c57b432b13f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
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
#line 1 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\Merge\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FPTLearning\Spring2022\SWP391\Week4\SourceCode\Merge\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da8d11c521cf75e4ba8e0892b18c57b432b13f6", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c9951c871a9a9c6c6157a81cfd4964aa953896a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<footer>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                <h1 class=\"logo\"><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1da8d11c521cf75e4ba8e0892b18c57b432b13f64619", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a></h1>
                <ul class=""contactinfo"">
                    <li class=""address""><strong>Address:</strong> 127 Sith Avenue, 54571 New York City </li>
                    <li class=""phone""><strong>Phone:</strong>  +49 123 456 789</li>
                    <li class=""email""><strong>E-mail:</strong>  info@bromine-theme.com</li>
                </ul>
                <ul class=""social"">
                    <li><a href=""#""><i class=""zmdi zmdi-facebook""></i></a></li>
                    <li>
                        <a href=""#""><i class=""zmdi zmdi-twitter""></i></a>
                    </li>
                    <li>
                        <a href=""#""><i class=""zmdi zmdi-google-old""></i></a>
                    </li>
                    <li>
                        <a href=""#""><i class=""zmdi zmdi-pinterest""></i></a>
                    </li>
                    <li>
                        <a href=""#""><i class=""zmdi zmdi-instagram""></i></a>
                    </li>
                    <li");
            WriteLiteral(@">
                        <a href=""#""><i class=""zmdi zmdi-rss""></i></a>
                    </li>
                </ul>
            </div>
            <div class=""col-md-2 col-sm-6 col-xs-12"">
                <h6>GET HELP</h6>
                <ul class=""information"">
                    <li><a href=""#"">Help and FAQ</a></li>
                    <li><a href=""#"">Video Courses</a></li>
                    <li><a href=""#"">Online Booking</a></li>
                    <li><a href=""#"">Online Support</a></li>
                </ul>
            </div>
            <div class=""col-md-2 col-sm-6 col-xs-12"">
                <h6>INFORMATION</h6>
                <ul class=""information"">
                    <li><a href=""#"">About us</a></li>
                    <li><a href=""#"">Our services</a></li>
                    <li><a href=""#"">Order history</a></li>
                    <li><a href=""#"">Information</a></li>
                </ul>
            </div>
            <div class=""col-md-2 col-sm-6 col-xs-12"">");
            WriteLiteral(@"
                <h6>MY ACCOUNT</h6>
                <ul class=""information"">
                    <li><a href=""#"">Plans &amp; Pricings</a></li>
                    <li><a href=""#"">Favorites</a></li>
                    <li><a href=""#"">Personal info</a></li>
                    <li><a href=""#"">Login</a></li>
                </ul>
            </div>
            <div class=""col-md-2 col-sm-12 col-xs-12"">
                <h6>QUICKLINKS</h6>
                <ul class=""information"">
                    <li><a href=""#"">Video Training</a></li>
                    <li><a href=""#"">Online Courses</a></li>
                    <li><a href=""#"">Become a teacher</a></li>
                    <li><a href=""#"">Contact</a></li>
                </ul>
            </div>
        </div>
        <div class=""row botbar"">
            <div class=""col-sm-7"">
                <p class=""copyright"">Copyright 2017 &copy; Bromine - Video Learning Platform  | All Rights Reserved</p>
            </div>
        </div>
    </");
            WriteLiteral("div>\r\n\r\n</footer>");
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
