#pragma checksum "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\Shared\_HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "109c839987eaaefe3951e6feba3e453a38c1f877"
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
#line 1 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week8\online_learning_SWP391\SWP391\Views\_ViewImports.cshtml"
using SWP391.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"109c839987eaaefe3951e6feba3e453a38c1f877", @"/Views/Shared/_HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28373cf24ff85914d872a3f8f52a8e9604e8c163", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-icon", new global::Microsoft.AspNetCore.Html.HtmlString("flag flag-uk"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-icon", new global::Microsoft.AspNetCore.Html.HtmlString("flag flag-us"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""top-bar"">
    <div class=""container"">
        <div class=""row d-flex justify-content-between"">
            <div class=""topbar-left"">
                <ul>
                    <li><a href=""faq-1.html""><i class=""fa fa-question-circle""></i>Ask a Question</a></li>
                    <li><a href=""javascript:;""><i class=""fa fa-envelope-o""></i>Support@website.com</a></li>
                </ul>
            </div>
            <div class=""topbar-right"">
                <ul>
                    <li>
                        <select class=""header-lang-bx"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109c839987eaaefe3951e6feba3e453a38c1f8775115", async() => {
                WriteLiteral("English UK");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109c839987eaaefe3951e6feba3e453a38c1f8776188", async() => {
                WriteLiteral("English US");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </li>
                    <li><a href=""login.html"">Login</a></li>
                    <li><a href=""register.html"">Register</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<div class=""sticky-header navbar-expand-lg"">
    <div class=""menu-bar clearfix"">
        <div class=""container clearfix"">
            <!-- Header Logo ==== -->
            <div class=""menu-logo"">
                <a href=""index.html""><img src=""assets/images/logo-white.png""");
            BeginWriteAttribute("alt", " alt=\"", 1285, "\"", 1291, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
            </div>
            <!-- Mobile Nav Button ==== -->
            <button class=""navbar-toggler collapsed menuicon justify-content-end"" type=""button"" data-toggle=""collapse"" data-target=""#menuDropdown"" aria-controls=""menuDropdown"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span></span>
                <span></span>
                <span></span>
            </button>
            <!-- Author Nav ==== -->
            <div class=""secondary-menu"">
                <div class=""secondary-inner"">
                    <ul>
                        <li><a href=""javascript:;"" class=""btn-link""><i class=""fa fa-facebook""></i></a></li>
                        <li><a href=""javascript:;"" class=""btn-link""><i class=""fa fa-google-plus""></i></a></li>
                        <li><a href=""javascript:;"" class=""btn-link""><i class=""fa fa-linkedin""></i></a></li>
                        <!-- Search Button ==== -->
                        <li class=""search-btn""><button id=""quik-searc");
            WriteLiteral("h-btn\" type=\"button\" class=\"btn-link\"><i class=\"fa fa-search\"></i></button></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <!-- Search Box ==== -->\r\n            <div class=\"nav-search-bar\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "109c839987eaaefe3951e6feba3e453a38c1f8779297", async() => {
                WriteLiteral("\r\n                    <input name=\"search\"");
                BeginWriteAttribute("value", " value=\"", 2624, "\"", 2632, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" class=\"form-control\" placeholder=\"Type to search\">\r\n                    <span><i class=\"ti-search\"></i></span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <span id=""search-remove""><i class=""ti-close""></i></span>
            </div>
            <!-- Navigation Menu ==== -->
            <div class=""menu-links navbar-collapse collapse justify-content-start"" id=""menuDropdown"">
                <div class=""menu-logo"">
                    <a href=""index.html""><img src=""assets/images/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 3138, "\"", 3144, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                </div>
                <ul class=""nav navbar-nav"">
                    <li class=""active"">
                        <a href=""javascript:;"">Home <i class=""fa fa-chevron-down""></i></a>
                        <ul class=""sub-menu"">
                            <li><a href=""index.html"">Home 1</a></li>
                            <li><a href=""index-2.html"">Home 2</a></li>
                        </ul>
                    </li>
                    <li>
                        <a href=""javascript:;"">Pages <i class=""fa fa-chevron-down""></i></a>
                        <ul class=""sub-menu"">
                            <li>
                                <a href=""javascript:;"">About<i class=""fa fa-angle-right""></i></a>
                                <ul class=""sub-menu"">
                                    <li><a href=""about-1.html"">About 1</a></li>
                                    <li><a href=""about-2.html"">About 2</a></li>
                                </ul>
             ");
            WriteLiteral(@"               </li>
                            <li>
                                <a href=""javascript:;"">Event<i class=""fa fa-angle-right""></i></a>
                                <ul class=""sub-menu"">
                                    <li><a href=""event.html"">Event</a></li>
                                    <li><a href=""events-details.html"">Events Details</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href=""javascript:;"">FAQ's<i class=""fa fa-angle-right""></i></a>
                                <ul class=""sub-menu"">
                                    <li><a href=""faq-1.html"">FAQ's 1</a></li>
                                    <li><a href=""faq-2.html"">FAQ's 2</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href=""javascript:;"">Contact Us<i class=""fa fa-angle-right""></i></a>
          ");
            WriteLiteral(@"                      <ul class=""sub-menu"">
                                    <li><a href=""contact-1.html"">Contact Us 1</a></li>
                                    <li><a href=""contact-2.html"">Contact Us 2</a></li>
                                </ul>
                            </li>
                            <li><a href=""portfolio.html"">Portfolio</a></li>
                            <li><a href=""profile.html"">Profile</a></li>
                            <li><a href=""membership.html"">Membership</a></li>
                            <li><a href=""error-404.html"">404 Page</a></li>
                        </ul>
                    </li>
                    <li class=""add-mega-menu"">
                        <a href=""javascript:;"">Our Courses <i class=""fa fa-chevron-down""></i></a>
                        <ul class=""sub-menu add-menu"">
                            <li class=""add-menu-left"">
                                <h5 class=""menu-adv-title"">Our Courses</h5>
                              ");
            WriteLiteral(@"  <ul>
                                    <li><a href=""courses.html"">Courses </a></li>
                                    <li><a href=""courses-details.html"">Courses Details</a></li>
                                    <li><a href=""profile.html"">Instructor Profile</a></li>
                                    <li><a href=""event.html"">Upcoming Event</a></li>
                                    <li><a href=""membership.html"">Membership</a></li>
                                </ul>
                            </li>
                            <li class=""add-menu-right"">
                                <img src=""assets/images/adv/adv.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6868, "\"", 6874, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            </li>
                        </ul>
                    </li>
                    <li>
                        <a href=""javascript:;"">Blog <i class=""fa fa-chevron-down""></i></a>
                        <ul class=""sub-menu"">
                            <li><a href=""blog-classic-grid.html"">Blog Classic</a></li>
                            <li><a href=""blog-classic-sidebar.html"">Blog Classic Sidebar</a></li>
                            <li><a href=""blog-list-sidebar.html"">Blog List Sidebar</a></li>
                            <li><a href=""blog-standard-sidebar.html"">Blog Standard Sidebar</a></li>
                            <li><a href=""blog-details.html"">Blog Details</a></li>
                        </ul>
                    </li>
                    <li class=""nav-dashboard"">
                        <a href=""javascript:;"">Dashboard <i class=""fa fa-chevron-down""></i></a>
                        <ul class=""sub-menu"">
                            <li><a href=""admin/");
            WriteLiteral(@"index.html"">Dashboard</a></li>
                            <li><a href=""admin/add-listing.html"">Add Listing</a></li>
                            <li><a href=""admin/bookmark.html"">Bookmark</a></li>
                            <li><a href=""admin/courses.html"">Courses</a></li>
                            <li><a href=""admin/review.html"">Review</a></li>
                            <li><a href=""admin/teacher-profile.html"">Teacher Profile</a></li>
                            <li><a href=""admin/user-profile.html"">User Profile</a></li>
                            <li>
                                <a href=""javascript:;"">Calendar<i class=""fa fa-angle-right""></i></a>
                                <ul class=""sub-menu"">
                                    <li><a href=""admin/basic-calendar.html"">Basic Calendar</a></li>
                                    <li><a href=""admin/list-view-calendar.html"">List View Calendar</a></li>
                                </ul>
                            </li>
         ");
            WriteLiteral(@"                   <li>
                                <a href=""javascript:;"">Mailbox<i class=""fa fa-angle-right""></i></a>
                                <ul class=""sub-menu"">
                                    <li><a href=""admin/mailbox.html"">Mailbox</a></li>
                                    <li><a href=""admin/mailbox-compose.html"">Compose</a></li>
                                    <li><a href=""admin/mailbox-read.html"">Mail Read</a></li>
                                </ul>
                            </li>
                        </ul>
                    </li>
                </ul>
                <div class=""nav-social-link"">
                    <a href=""javascript:;""><i class=""fa fa-facebook""></i></a>
                    <a href=""javascript:;""><i class=""fa fa-google-plus""></i></a>
                    <a href=""javascript:;""><i class=""fa fa-linkedin""></i></a>
                </div>
            </div>
");
            WriteLiteral("            <!-- Navigation Menu END ==== -->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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