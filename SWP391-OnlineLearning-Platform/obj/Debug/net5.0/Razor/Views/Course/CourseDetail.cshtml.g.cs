#pragma checksum "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393f7e2d021b911768d2d679ec96956a48790768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseDetail), @"mvc.1.0.view", @"/Views/Course/CourseDetail.cshtml")]
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
#line 1 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\_ViewImports.cshtml"
using SWP391_OnlineLearning_Platform.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"393f7e2d021b911768d2d679ec96956a48790768", @"/Views/Course/CourseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cc414232cb72a548af1b9bdfef0c3bcad4d1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CourseList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("resp-img course-preview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
  
    ViewData["Title"] = "CourseDetail";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
  
    var course = Model.course;
    var cate = ViewBag.Category;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>

    <div class=""page-heading text-center"">
        <div class=""container"">
            <h2>SINGLE COURSE</h2>
            <p class=""breadcrumbs"">
                <a href=""#"">Home</a>
                <i class=""zmdi zmdi-chevron-right""></i>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393f7e2d021b911768d2d679ec96956a487907686217", async() => {
                WriteLiteral("Courses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <i class=\"zmdi zmdi-chevron-right\"></i>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393f7e2d021b911768d2d679ec96956a487907687656", async() => {
#nullable restore
#line 20 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                                                                                        Write(cate.Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                                                                       WriteLiteral(cate.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <i class=\"zmdi zmdi-chevron-right\"></i>\r\n                <span>");
#nullable restore
#line 22 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                 Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-9\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "393f7e2d021b911768d2d679ec96956a4879076810920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 906, "~/img/", 906, 6, true);
#nullable restore
#line 29 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
AddHtmlAttributeValue("", 912, course.Thumbnail_URL, 912, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h3>");
#nullable restore
#line 30 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
               Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p class=""class-details"">
                    <span class=""lessons""><i class=""zmdi zmdi-assignment""></i>12 LESSONS</span>
                    <span class=""duration""><i class=""zmdi zmdi-time""></i>3:15h</span>
                    <span class=""views""><i class=""zmdi zmdi-eye""></i>2241 VIEWS</span>
                    <span class=""tag""><i class=""zmdi zmdi-label""></i>");
#nullable restore
#line 35 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                                                                Write(cate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </p>\r\n                <h4>COURSE DETAILS</h4>\r\n                <p class=\"abs\">\r\n                    ");
#nullable restore
#line 39 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
               Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <h5>What does this course include?</h5>
                <ul class=""includes"">
                    <li>Lorem ipsum dolor sit amet, consectetuer adipisc.</li>
                    <li>Aliquam tincidunt mauris eu risus.</li>
                    <li>Vestibulum auctor dapibus neque.</li>
                    <li>Nunc dignissim risus id metus.</li>
                    <li>Cras ornare tristique elit.</li>
                    <li>Vivamus vestibulum nulla nec ante.</li>
                </ul>
                <h4>COURSE CONTENT</h4>
                <ul class=""course-accordion"">
                    <li class=""accordion-option opened"">
                        <div class=""option-title"">Section #1: Tools in Photoshop <span>(4 videos)</span></div>
                        <div class=""option-wrapper"">
                            <ul class=""option-items"">
                                <li class=""option-item"">
                                    <div class=""pull-right"">
  ");
            WriteLiteral(@"                                      <span class=""duration"">0.15 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Epsum factorial non deposit quid.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">0.31 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Pro quo hic escorol olypian.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                   ");
            WriteLiteral(@" <a href=""#"">Et gorilla congolium sic.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Ad nauseum souvlaki ignitus carborundum.</a>
                                </li>
                            </ul>
                        </div>
                    </li>
                    <li class=""accordion-option"">
                        <div class=""option-title"">Section #2: Working with layers <span>(6 videos)</span></div>
                        <div class=""option-wrapper"">
                            <ul class=""option-items"">
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                 ");
            WriteLiteral(@"       <span class=""duration"">0.15 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Epsum factorial non deposit quid.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">0.31 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Pro quo hic escorol olypian.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Et gorilla congoli");
            WriteLiteral(@"um sic.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Ad nauseum souvlaki ignitus carborundum.</a>
                                </li>
                            </ul>
                        </div>
                    </li>
                    <li class=""accordion-option"">
                        <div class=""option-title"">Section #3: Functions and effects <span>(5 videos)</span></div>
                        <div class=""option-wrapper"">
                            <ul class=""option-items"">
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration""");
            WriteLiteral(@">0.15 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Epsum factorial non deposit quid.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">0.31 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Pro quo hic escorol olypian.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Et gorilla congolium sic.</a>
                ");
            WriteLiteral(@"                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Ad nauseum souvlaki ignitus carborundum.</a>
                                </li>
                            </ul>
                        </div>
                    </li>
                    <li class=""accordion-option"">
                        <div class=""option-title"">Section #4: New features in Adobe Photoshop <span>(3 videos)</span></div>
                        <div class=""option-wrapper"">
                            <ul class=""option-items"">
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">0.15 h</span><a hr");
            WriteLiteral(@"ef=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Epsum factorial non deposit quid.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">0.31 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Pro quo hic escorol olypian.</a>
                                </li>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Et gorilla congolium sic.</a>
                                </l");
            WriteLiteral(@"i>
                                <li class=""option-item"">
                                    <div class=""pull-right"">
                                        <span class=""duration"">1.29 h</span><a href=""#""><i class=""zmdi zmdi-star""></i></a>
                                    </div>
                                    <a href=""#"">Ad nauseum souvlaki ignitus carborundum.</a>
                                </li>
                            </ul>
                        </div>
                    </li>
                </ul>
                <h4>COMMENTS</h4>
                <div class=""comment clearfix"">
                    <img src=""http://placehold.it/65x65"" alt=""Avatar"" class=""pull-left"">
                    <a href=""#"">Jack Porter</a>
                    <span class=""postedon"">14 JANUARY 2016 AT 12:24 AM</span>
                    <p class=""abs"">
                        Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat
                ");
            WriteLiteral(@"        facer possim assum. Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh
                        euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
                    </p>
                    <a href=""#"" class=""pull-right greybutton"">REPLY</a>
                </div>
                <div class=""comment subcomment clearfix"">
                    <img src=""http://placehold.it/65x65"" alt=""Avatar"" class=""pull-left"">
                    <a href=""#"">Mark Terrenzi</a>
                    <span class=""postedon"">14 JANUARY 2016 AT 12:35 AM</span>
                    <p class=""abs"">
                        Ivel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui
                        blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.
                    </p>
                    <a href=""#"" class=""pull-right greybutton"">REPLY</a>
                </div>
                <h4>LEAVE A RE");
            WriteLiteral("PLY</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393f7e2d021b911768d2d679ec96956a4879076824913", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <label class=""req"">NAME</label>
                            <input type=""text"" name=""name"" placeholder=""enter your name"" required>
                        </div>
                        <div class=""col-sm-4"">
                            <label class=""req"">E-MAIL ADDRESS</label>
                            <input type=""text"" name=""email"" placeholder=""enter e-mail address"" required>
                        </div>
                        <div class=""col-sm-4"">
                            <label>WEBSITE</label>
                            <input type=""text"" name=""site"" placeholder=""https://"">
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <label class=""req"">MESSAGE</label>
                            <textarea name=""name"" placeholder=""type in a message"" require");
                WriteLiteral(@"d></textarea>
                        </div>
                    </div>
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""pull-right"">
                                <button class=""greybutton"">SUBMIT</button>
                            </div>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-3"">
                <div class=""order text-center"">
                    <p class=""price"">59</p>
                    <p>SINGLE PRICE</p>
                    <a href=""#"" class=""blueplay"">BUY THIS COURSE</a>
                    <p class=""order-or""><span>OR</span></p>
                    <p>SIGN UP FOR</p>
                    <a href=""#"" class=""greybutton"">PREMIUM MEMBERSHIP</a>
                </div>
                <div class=""pros"">
                    <h4>ABOUT THE TEACHER</h4>
                    <div class=""teacher text-center"">
                        <div class=""imgcontainer"">
                            <img src=""http://placehold.it/130x130"" alt=""Avatar"">
                            <div class=""overlay"">
                                <img src=""http://placehold.it/18x17"" alt=""Profile"">
                                <p>8 VIDEOS</p>
                            </div>
                        </div>
                        <a href=""#""");
            WriteLiteral(@">Jonathan Creon</a>
                        <p>DESINGER</p>
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
                                <a href=""#""><i class=""zmdi zmdi-email""></i></a>
                            </li>
                            <li>
                                <a href=""#""><i class=""zmdi zmdi-globe-alt""></i></a>
                            </li>
                        </ul>
                    </div>
    ");
            WriteLiteral(@"            </div>
                <div class=""ratings"">
                    <h4>COURSE RATINGS</h4>
                    <div class=""rating"">
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#"" class=""on""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                        <a href=""#""><i class=""zmdi zmdi-star zmdi-hc-2x""></i></a>
                    </div>
                    <p>(37 votes, average: <strong>4.8</strong> out of 5)</p>
                </div>
                <div class=""popular-courses index-3-categories"">
                    <h4>POPULAR COURSES</h4>
                    <div class=""courses-side-slick"">
                        <div class=""category-with-bg text-center cat1"">
                            <h5>Content-Managemen");
            WriteLiteral(@"t-Systems</h5>
                            <p>IT-Service for CMS like WordPress</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                        <div class=""category-with-bg text-center cat2"">
                            <h5>User Experience / UX Design</h5>
                            <p>Workshop for UX Design</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                        <div class=""category-with-bg text-center cat3"">
                            <h5>Typography &amp; Writing</h5>
                            <p>Work with InDesign</p>
                            <a href=""#"" class=""goto""><i class=""zmdi zmdi-long-arrow-right""></i></a>
                        </div>
                    </div>
                </div>
                <div class=""categories"">
                    <h6>CATEGORIES</h6>
               ");
            WriteLiteral("     <ul>\r\n");
#nullable restore
#line 305 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                         foreach (var category in Model.categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "393f7e2d021b911768d2d679ec96956a4879076832471", async() => {
#nullable restore
#line 307 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                                                                                                            Write(category.Value);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-cate", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 307 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                                                                                       WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-cate", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["cate"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 308 "D:\FPTU-Learning\Spring2022\SWP391\Week4\online_learning_SWP391\SWP391-OnlineLearning-Platform\Views\Course\CourseDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</main>");
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