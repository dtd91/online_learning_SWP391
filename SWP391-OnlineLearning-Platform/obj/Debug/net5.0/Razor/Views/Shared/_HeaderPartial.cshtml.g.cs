#pragma checksum "D:\FPTLearning\Spring2022\SWP391\Week 5\Source Code\online_learning_SWP391-98d141cce00ef7002e8aaf55669c8b4f7297a91e\SWP391-OnlineLearning-Platform\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7668eeb32b13bfa91606cfbbabc1d357ce00e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/_HeaderPartial.cshtml")]
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
#line 1 "D:\FPTLearning\Spring2022\SWP391\Week 5\Source Code\online_learning_SWP391-98d141cce00ef7002e8aaf55669c8b4f7297a91e\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTLearning\Spring2022\SWP391\Week 5\Source Code\online_learning_SWP391-98d141cce00ef7002e8aaf55669c8b4f7297a91e\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7668eeb32b13bfa91606cfbbabc1d357ce00e8", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6a837e61f6c7e2776282f86d4e5ffaad8856c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PublicFeature", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"<header>
    <ul class=""pull-right lang"">
        <li class=""selected""><a href=""#"">EN</a></li>
        <li><a href=""#"">DE</a></li>
        <li><a href=""#"">FR</a></li>
        <li><a href=""#"">PO</a></li>
    </ul>
    <div class=""container"">
        <div id=""topbar"">
            <div class=""pull-right"">
                <div class=""navigation"">
                    <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                        <i class=""zmdi zmdi-menu zmdi-hc-lg""></i>
                    </button>
                    <nav class=""collapse navbar-collapse"" id=""myNavbar"">
                        <ul>
                            <li class=""active"">
                                <a href=""#"">Home</a>
                            </li>
                            <li>
                                <a href=""#"">Online Courses</a>
                                <ul class=""submenu clearfix"">
                                    <li>
                                   ");
            WriteLiteral(@"     <ul class=""sub-column"">
                                            <li><a href=""#"">All Courses (817)</a></li>
                                            <li><a href=""#"">Business (18)</a></li>
                                            <li><a href=""#"">CMS (14)</a></li>
                                            <li><a href=""#"">Design (17)</a></li>
                                            <li><a href=""#"">Development (23)</a></li>
                                            <li><a href=""#"">Humanities (19)</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <ul class=""sub-column"">
                                            <li><a href=""#"">Medicine (8)</a></li>
                                            <li><a href=""#"">Music (47)</a></li>
                                            <li><a href=""#"">Photography (68)</a></li>
                                            <li><a hre");
            WriteLiteral(@"f=""#"">Photoshop (87)</a></li>
                                            <li><a href=""#"">IT &amp; Software (41)</a></li>
                                            <li><a href=""#"">Lifestyle (54)</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <ul class=""sub-column"">
                                            <li><a href=""#"">Science (54)</a></li>
                                            <li><a href=""#"">Languages (83)</a></li>
                                            <li><a href=""#"">Business (52)</a></li>
                                            <li><a href=""#"">SEO (39)</a></li>
                                            <li><a href=""#"">Marketing (44)</a></li>
                                            <li><a href=""#"">Video Production (33)</a></li>
                                        </ul>
                                    </li>
                                </u");
            WriteLiteral(@"l>
                            </li>
                            <li>
                                <a href=""#"">Categories</a>
                                <ul class=""submenu submenu-list"">
                                    <li><a href=""categories.html"">Categories</a></li>
                                    <li><a href=""courses-3-col.html"">Courses 3 column</a></li>
                                    <li><a href=""courses-4-col.html"">Courses 4 column</a></li>
                                    <li><a href=""courses-gallery.html"">Courses Gallery</a></li>
                                    <li><a href=""course-single.html"">Course Single</a></li>
                                    <li><a href=""courses-list.html"">Courses List</a></li>
                                    <li><a href=""courses-list-sidebar.html"">Courses List Sidebar</a></li>
                                    <li><a href=""courses-sidebar.html"">Courses Sidebar</a></li>
                                </ul>
                            </li>
 ");
            WriteLiteral(@"                           <li>
                                <a href=""#"">Support</a>
                                <ul class=""submenu submenu-list"">
                                    <li><a href=""how-it-works.html"">How it works</a></li>
                                    <li><a href=""pricing.html"">Pricing</a></li>
                                    <li><a href=""services-1.html"">Services 1</a></li>
                                    <li><a href=""services-2.html"">Services 2</a></li>
                                    <li><a href=""teachers.html"">Teachers</a></li>
                                    <li><a href=""teacher-single.html"">Teacher Single</a></li>
                                    <li><a href=""blog1.html"">Blog 1</a></li>
                                    <li><a href=""blog2.html"">Blog 2</a></li>
                                </ul>
                            </li>
                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa7668eeb32b13bfa91606cfbbabc1d357ce00e811463", async() => {
                WriteLiteral("Blog");
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
            WriteLiteral("</li>\n\n");
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa7668eeb32b13bfa91606cfbbabc1d357ce00e812891", async() => {
                WriteLiteral("Goto Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>

                        </ul>
                    </nav>
                </div>
                <a href=""#"" class=""blueplay login"">LOGIN</a>
                <a href=""#"" class=""register"">REGISTER</a>
                <div class=""cart"">
                    <a href=""#""><i class=""zmdi zmdi-case zmdi-hc-lg""></i><span>4</span></a>
                    <div class=""cart-container"">
                        <h6>SHOPPING CART (2)</h6>
                        <div class=""cart-item clearfix"">
                            <img src=""http://placehold.it/94x94"" alt=""cart item"" class=""pull-left"">
                            <a href=""#"">How to become an UX Designer</a>
                            <p class=""quantity"">1x $39,99</p>
                            <button class=""remove"">x DELETE</button>
                        </div>
                        <div class=""cart-item clearfix"">
                            <img src=""http://placehold.it/94x94"" alt=""cart item"" class=""pull-left"">
                            <a href=""#"">Ho");
            WriteLiteral(@"w to become an UX Designer</a>
                            <p class=""quantity"">1x $39,99</p>
                            <button class=""remove"">x DELETE</button>
                        </div>
                        <div class=""cart-controls text-center"">
                            <a href=""#"" class=""checkout"">CHECKOUT</a>
                            <a href=""#"" class=""viewcart"">VIEW CART</a>
                            <a href=""#"" class=""addcourse"">+ ADD COURSE</a>
                        </div>
                    </div>
                </div>
                <div class=""search"">
                    <a href=""#"" class=""search""><i class=""zmdi zmdi-search zmdi-hc-lg""></i></a>
                    <div class=""search-something"">
                        <input type=""search"" placeholder=""search for something"">
                        <a href=""#""><i class=""zmdi zmdi-search""></i></a>
                    </div>
                </div>
            </div>
            <h1 class=""logo""><a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fa7668eeb32b13bfa91606cfbbabc1d357ce00e816591", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></h1>\n        </div>\n    </div>\n</header>");
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
